using Microsoft.Extensions.Options;

namespace Platform
{
    public class QueryStringMiddleWare
    {
        private RequestDelegate? next;

        public QueryStringMiddleWare() 
        {
            // nothing, no initilise the next delegate
        }

        public QueryStringMiddleWare(RequestDelegate nextDelegate)
        {
            next = nextDelegate;
        }


        // a single middleware object is used to handle all requests,
        // which means that the code in Invode method must be thread-safe.
        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Method == HttpMethods.Get && context.Request.Query["custom"] == "true")
            {
                if (!context.Response.HasStarted)
                {
                    context.Response.ContentType = "text/plain";
                }

                await context.Response.WriteAsync("Class Middleware \n");
            }

            if (next != null)
            {
                await next(context);
            }
        }
    }

    public class LocationMiddleware
    {
        private RequestDelegate next;
        private MessageOptions options;

        // option is resolved using previously created object by Services.Config<MessageOptions> in program.cs,
        // then DI into this constructor
        public LocationMiddleware(RequestDelegate nextDelegate, IOptions<MessageOptions> opts)
        {
            next = nextDelegate;
            options = opts.Value;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path == "/location2")
            {
                await context.Response.WriteAsync($"{options.CityName}, {options.CountryName}");
            }
            else
            {
                await next(context);
            }
        }
    }
}
