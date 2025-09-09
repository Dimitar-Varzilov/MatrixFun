using MatrixFun.Extensions;
using MatrixFun.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

if (OperatingSystem.IsWindows())
{
	Console.SetWindowSize(200, 30);
}
HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

// Register services
builder.Services.RegisterServices();


using IHost host = builder.Build();

// Get the service and run the application
IMatrixGameService gameService = host.Services.GetRequiredService<IMatrixGameService>();
gameService.Run();



