using MatrixFun.Interfaces;
using MatrixFun.Services;
using Microsoft.Extensions.DependencyInjection;

namespace MatrixFun.Extensions
{
	internal static class ServiceExtension
	{
		public static IServiceCollection RegisterServices(this IServiceCollection services)
		{
			services.AddTransient<IMatrixService, MatrixService>();
			services.AddTransient<IMatrixGameService, MatrixGameService>();
			services.AddTransient<ISettingsService, SettingsService>();
			services.AddTransient<IExceptionService, ExceptionService>();
            services.AddTransient<IConsoleService, ConsoleService>();

			return services;
		}
	}
}
