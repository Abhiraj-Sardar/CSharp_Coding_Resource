namespace ASP.NET_Core_Tutorial
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Creating the Web Host and Configuring the Services
            var builder = WebApplication.CreateBuilder(args);

            // Building the Application
            var app = builder.Build();

            // Setting Up Endpoints
            //app.MapGet("/", () => "Hello World!");

            /* middleware example */

            //app.MapGet("/greet", () => "Hello !!"); // Hello !!
            //app.MapGet("/greet/{name}", (string name) => $"Hello {name}"); // Hello Abhiraj
            //app.Run(Middleware.FirstMiddleware); // Getting Response from First Middleware
            //app.Use(async (context,next) =>
            //{
            //    await context.Response.WriteAsync("Sequential Middleware 1");
            //    await next(); //call the next middleware after this
            //});
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("\nSequential Middleware 2");
            //});


            // app.MapGet("/", () => "Worker Process Name : " + System.Diagnostics.Process.GetCurrentProcess().ProcessName); // Worker Process Name : iisexpress  /* example of Hosting Method */

            /* example of appsettings.json */

            //string? name = builder.Configuration.GetValue<String>("MyName", "Default Value");
            //string? name2 = builder.Configuration["MyName"];
            //app.MapGet("/", () => $"{name}");  // Abhiraj Sardar


            /* wwwroot example */

            //app.MapGet("/webroot", () => $"EnvironmentName: {app.Environment.EnvironmentName} \n" +
            //$"ApplicationName: {app.Environment.ApplicationName} \n" +
            //$"WebRootPath: {app.Environment.WebRootPath} \n" +
            //$"ContentRootPath: {app.Environment.ContentRootPath}");
            //output:
            //EnvironmentName: Development
            //ApplicationName: ASP.NET_Core_Tutorial
            //WebRootPath: C: \Users\SAAB04\Desktop\Abhiraj Sardar\ASP.NET_Core_Tutorial\ASP.NET_Core_Tutorial\wwwroot
            //ContentRootPath: C: \Users\SAAB04\Desktop\Abhiraj Sardar\ASP.NET_Core_Tutorial\ASP.NET_Core_Tutorial

            //app.UseStaticFiles(); // now we can directly access our static files from wwwroot  // gotohttps://localhost:44335/apple.jpg


            /* Default Files example */
            app.UseDefaultFiles();
            app.UseStaticFiles(); // we will see that the content of index.html is displayed at "https://localhost:44335/"


            // Running the Application
            app.Run();
        }
    }
}
