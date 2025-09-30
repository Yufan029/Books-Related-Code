using Microsoft.Extensions.Options;
using Platform;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MessageOptions>(options =>
{
    options.CityName = "Albany";
});


var app = builder.Build();


app.MapGet("/location", async (HttpContext context, IOptions<MessageOptions> msgOpts) =>
{
    MessageOptions opts = msgOpts.Value;
    await context.Response.WriteAsync($"{opts.CityName}, {opts.CountryName}");
});



app.Use(async (context, next) =>
{
    context.Response.ContentType = "text/plain";
    await context.Response.WriteAsync("\n1\n");

    await next();

    await context.Response.WriteAsync($"\nStatus Code: {context.Response.StatusCode}");
    await context.Response.WriteAsync("\n1\n");
});

// when asp.net core sees it, it will create the LocationMiddleware
app.UseMiddleware<LocationMiddleware>();


app.Use(async (context, next) =>
{
    if (context.Request.Path == "/short")
    {
        // short-circuiting
        await context.Response.WriteAsync($"Reqeust Short Circuited");
    }
    else
    {
        await next();
    }
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\n2\n");
    Console.WriteLine("another 2");
    if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
    {
        //context.Response.ContentType = "text/plain";
        await context.Response.WriteAsync("Custom Middleware \n");
    }

    await next();

    await context.Response.WriteAsync("\n2\n");
});

app.Map("/branch", branch =>
{
    branch.UseMiddleware<Platform.QueryStringMiddleWare>();

    branch.Use(async (HttpContext context, Func<Task> next) =>
    {
        await context.Response.WriteAsync($"Branch Middleware");
    });
});

// response to the path like /branchcccc
app.MapWhen(context => context.Request.Path.ToString().Contains("branch"), branch =>
{
    branch.Use(async (HttpContext context, Func<Task> next) =>
    {
        await context.Response.WriteAsync($"map when => Branch Middleware");
    });
});


// Terminal middleware
((IApplicationBuilder)app).Map("/branch2", branch =>
{
    branch.Run(async (context) =>
    {
        await context.Response.WriteAsync($"Branch Middleware");
    });
});

// another terminal middleware, will not be running ever, since there's another terminal middleware above it, 
// never reach this point and below
app.Map("/branch3", branch =>
{
    branch.Run(new Platform.QueryStringMiddleWare().Invoke);
});

app.UseMiddleware<Platform.QueryStringMiddleWare>();

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("\n3\n");
    await next();
    await context.Response.WriteAsync("\n3\n");
});

app.MapGet("/", () => "Hello World!");

app.Run();
