using Microsoft.Extensions.Options;
using Platform;

var builder = WebApplication.CreateBuilder(args);

// custom constrain, setup via option pattern
builder.Services.Configure<RouteOptions>(opts => {
    opts.ConstraintMap.Add("countryName", typeof(CountryRouteConstraint));
});

#region chapter 12
//builder.Services.Configure<MessageOptions>(options =>
//{
//    options.CityName = "Albany";
//});
#endregion chapter 12

var app = builder.Build();

app.MapGet("capital/{country:countryName}", Capital.Endpoint);

#region chapter 12
//app.MapGet("/location", async (HttpContext context, IOptions<MessageOptions> msgOpts) =>
//{
//    MessageOptions opts = msgOpts.Value;
//    await context.Response.WriteAsync($"{opts.CityName}, {opts.CountryName}");
//});



//app.Use(async (context, next) =>
//{
//    context.Response.ContentType = "text/plain";
//    await context.Response.WriteAsync("\n1\n");

//    await next();

//    await context.Response.WriteAsync($"\nStatus Code: {context.Response.StatusCode}");
//    await context.Response.WriteAsync("\n1\n");
//});

//// when asp.net core sees it, it will create the LocationMiddleware
//app.UseMiddleware<LocationMiddleware>();


//app.Use(async (context, next) =>
//{
//    if (context.Request.Path == "/short")
//    {
//        // short-circuiting
//        await context.Response.WriteAsync($"Reqeust Short Circuited");
//    }
//    else
//    {
//        await next();
//    }
//});

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("\n2\n");
//    Console.WriteLine("another 2");
//    if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
//    {
//        //context.Response.ContentType = "text/plain";
//        await context.Response.WriteAsync("Custom Middleware \n");
//    }

//    await next();

//    await context.Response.WriteAsync("\n2\n");
//});

//app.Map("/branch", branch =>
//{
//    branch.UseMiddleware<Platform.QueryStringMiddleWare>();

//    branch.Use(async (HttpContext context, Func<Task> next) =>
//    {
//        await context.Response.WriteAsync($"Branch Middleware");
//    });
//});

//// response to the path like /branchcccc
//app.MapWhen(context => context.Request.Path.ToString().Contains("branch"), branch =>
//{
//    branch.Use(async (HttpContext context, Func<Task> next) =>
//    {
//        await context.Response.WriteAsync($"map when => Branch Middleware");
//    });
//});


//// Terminal middleware
//((IApplicationBuilder)app).Map("/branch2", branch =>
//{
//    branch.Run(async (context) =>
//    {
//        await context.Response.WriteAsync($"Branch Middleware");
//    });
//});

//// another terminal middleware, will not be running ever, since there's another terminal middleware above it, 
//// never reach this point and below
//app.Map("/branch3", branch =>
//{
//    branch.Run(new Platform.QueryStringMiddleWare().Invoke);
//});

//app.UseMiddleware<Platform.QueryStringMiddleWare>();

//app.Use(async (context, next) =>
//{
//    await context.Response.WriteAsync("\n3\n");
//    await next();
//    await context.Response.WriteAsync("\n3\n");
//});

//app.MapGet("/", () => "Hello World!");
#endregion chapter12 


app.UseRouting();

//app.UseMiddleware<Population>();
//app.UseMiddleware<Capital>();

//#pragma warning disable ASP0014
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapGet("routing", async context =>
//    {
//        await context.Response.WriteAsync("Request Was Routed");
//    });
//    endpoints.MapGet("capital/uk", new Capital().Invoke);
//    endpoints.MapGet("population/paris", new Population().Invoke);
//});


app.MapGet("{first}/{second}/{third}", async context => {
    await context.Response.WriteAsync("Request Was Routed\n");
    foreach (var kvp in context.Request.RouteValues)
    {
        await context.Response.WriteAsync($"{kvp.Key}: {kvp.Value}\n");
    }
});

app.MapGet("routing", async context =>
{
    await context.Response.WriteAsync("Request Was Routed");
});

// below
app.MapGet("capital/{country=France}", Capital.Endpoint);
//regular expression are case-insensitive
app.MapGet("capital/{country:regex(^uk|france|monaco$)}", Capital.Endpoint);
app.MapGet("population/{city?}", Population.Endpoint).WithMetadata(new RouteNameMetadata("whatevernameyougive"));

// in the capital/monaco, dependency on the route, the url is generated from this patter, no hardcoded path anymore.
// so in future if it changes back to population, there's no need to change code in capital. as long as the names in metadata are same.
//app.MapGet("size/{city}", Population.Endpoint).WithMetadata(new RouteNameMetadata("whatevernameyougive"));


app.MapGet("files/{filename}.{ext}", async context => {
    await context.Response.WriteAsync("Request Was Routed\n");
    foreach (var kvp in context.Request.RouteValues)
    {
        await context.Response
        .WriteAsync($"{kvp.Key}: {kvp.Value}\n");
    }
});

app.MapGet("example/red{color}", async context =>
{
    await context.Response.WriteAsync("reach example/red{color}");
});

app.MapGet("{first}/{second}/{*catchall}", async context => {
    await context.Response.WriteAsync("Request Was Routed\n");
    foreach (var kvp in context.Request.RouteValues)
    {
        await context.Response
        .WriteAsync($"{kvp.Key}: {kvp.Value}\n");
    }
});


app.MapGet("{first:int}/{second:bool}", async context => {
    await context.Response.WriteAsync("Request Was Routed\n");
    foreach (var kvp in context.Request.RouteValues)
    {
        await context.Response
        .WriteAsync($"{kvp.Key}: {kvp.Value}\n");
    }
});
app.MapGet("{first:alpha:length(3)}/{second:bool}", async context => {
    await context.Response.WriteAsync("Request Was Routed\n");
    foreach (var kvp in context.Request.RouteValues)
    {
        await context.Response
        .WriteAsync($"{kvp.Key}: {kvp.Value}\n");
    }
});

app.MapFallback(async context => {
    await context.Response.WriteAsync("Routed to fallback endpoint");
});


//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Terminal Middleware Reached");
//});


app.Run();
