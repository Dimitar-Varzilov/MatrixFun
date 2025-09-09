using MatrixFun.Interfaces;

namespace MatrixFun.Services
{
	internal class ExceptionService : IExceptionService
	{
		public void HandleException<T>(T? exception) where T : Exception
		{
			if (exception == null) return;
			DisplayMessage(exception.Message);
		}

		public static void ShowErrorMessage(string? message)
		{
			if (message == null) return;
			DisplayMessage(message);
		}

		private static void DisplayMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine($"Error occurred - > {message} \n Please close the application and contact our support team.");
			Console.ForegroundColor = ConsoleColor.White;
		}
	}
}
