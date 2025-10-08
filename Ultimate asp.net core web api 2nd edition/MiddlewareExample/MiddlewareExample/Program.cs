var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.Use(async (context, next) => 
{
    // cannot send response to client before next.Invoke(), 
    // can cause exception if we try to set status code or modify headers of the response
    //await context.Response.WriteAsync("Hello from the middleware component 1.");
    Console.WriteLine($"before next in Use method"); 
    await next.Invoke();
    Console.WriteLine($"after next in Use method");
});

app.Map("/usingmapbranch", builder => 
{ 
    builder.Use(async (context, next) =>
    { 
        Console.WriteLine("Map branch in Use method before next");
        await next.Invoke();
        Console.WriteLine("Map branch in Use method after next");
    });

    builder.Run(async context =>
    {
        Console.WriteLine($"Map branch in Run method");
        await context.Response.WriteAsync("map branch.");
    });
});

app.MapWhen(
    context => context.Request.Query.ContainsKey("testquerystring"),
    builder => 
    {
        builder.Run(async context => 
        {
            await context.Response.WriteAsync("MapWhen branch.");
        });
    }
);


app.Run(async context =>
{
    // Below line will cause exception, since the response has been send to client already
    //System.InvalidOperationException: StatusCode cannot be set because the response has already started.
    //context.Response.StatusCode = 200;

    Console.WriteLine($"Writing the response to the client in the Run method");
    await context.Response.WriteAsync("Hello from the middleware component 2."); 
});

app.MapControllers();

app.Run();
