namespace ASP.NET_Core_Tutorial
{
    public class Middleware
    {
        public static async Task FirstMiddleware(HttpContext context)
        {
            await context.Response.WriteAsync("Getting Response from First Middleware");
        }

        public static async Task SecondMiddleware(HttpContext context)
        {
            await context.Response.WriteAsync("Getting Response from Second Middleware");
        }
    }
}
