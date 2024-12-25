using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Use Startup for service registration
var startup = new Startup();
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Use Startup for middleware configuration
startup.Configure(app, app.Environment);

app.Run();
