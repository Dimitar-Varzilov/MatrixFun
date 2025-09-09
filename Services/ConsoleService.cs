using Figgle;
using Figgle.Fonts;
using MatrixFun.Constants;
using MatrixFun.Interfaces;

namespace MatrixFun.Services
{
	internal class ConsoleService : IConsoleService
	{
		public int IntRead()
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
		public double DoubleRead()
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
		public string StringRead(string? cancelationString = null, List<string>? stringList = null)
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

		public int ShowMenu(string[] options)
		{
			int currentSelection = 0;

			ConsoleKey key;
			Console.CursorVisible = false;

			do
			{
				Console.Clear();
				for (int i = 0; i < options.Length; i++)
				{
					if (i == currentSelection)
						Console.Write("-> ");
					else
						Console.Write("   ");

					Console.WriteLine(options[i]);
				}

				key = Console.ReadKey(true).Key;

				switch (key)
				{
					case ConsoleKey.UpArrow:
						if (currentSelection > 0)
							currentSelection--;
						break;
					case ConsoleKey.DownArrow:
						if (currentSelection < options.Length - 1)
							currentSelection++;
						break;
				}
			} while (key != ConsoleKey.Enter);

			Console.CursorVisible = true;
			Console.Clear();
			return currentSelection;
		}

		public void ShowWelcomeMessage()
		{
			Console.CursorVisible = false;
			Console.ForegroundColor = ConsoleColor.DarkGreen;
			string welcomeMsg = FiggleFonts
				.Basic
				.Render(MatrixFunConstants.WelcomeMessage);
			string[] welcomeArt = welcomeMsg.Split('\n');

			int width = Console.WindowWidth;
			int height = Console.WindowHeight;
			int artHeight = welcomeArt.Length;
			int centerY = (height - artHeight) / 2;

			Console.Clear();
			for (int i = 0; i < welcomeArt.Length; i++)
			{
				int lineLength = welcomeArt[i].Length;
				int centerX = Math.Max(0, (width - lineLength) / 2);
				Console.SetCursorPosition(centerX, centerY + i);
				Console.Write(welcomeArt[i]);
				Thread.Sleep(50);
			}

			Thread.Sleep(5000);
			Console.ForegroundColor = ConsoleColor.White;
			Console.CursorVisible = true;
			Console.Clear();
		}
	}
}
