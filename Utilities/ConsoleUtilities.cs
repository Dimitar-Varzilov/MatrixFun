namespace Console_App.Utilities
{
	internal static class ConsoleUtilities
	{
		public static int IntRead()
		{
			int returnValue;
			while (true)
			{
				bool success = int.TryParse(Console.ReadLine()?.Trim(), out returnValue);
				if (!success)
				{
					Console.WriteLine("Invalid Integer");
					continue;
				}
				break;
			}
			return returnValue;
		}
		public static double DoubleRead()
		{
			double returnValue;
			while (true)
			{
				bool success = double.TryParse(Console.ReadLine()?.Trim(), out returnValue);
				if (!success)
				{
					Console.WriteLine("Invalid Double");
					continue;
				}
				break;
			}
			return returnValue;
		}
		public static string StringRead(string? cancelationString = null, List<string>? stringList = null)
		{
			while (true)
			{
				string? input = Console.ReadLine();
				if (input == null)
				{
					Console.WriteLine("Invalid String");
					continue;
				}
				stringList?.Add(input);
				if (cancelationString != null && input != cancelationString)
					continue;
				else if (stringList != null)
					continue;

				return input;
			}
		}

	}
}
