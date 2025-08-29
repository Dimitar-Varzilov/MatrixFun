namespace MatrixFun.Utilities
{
	internal static class NumberUtilities
	{
		private static readonly Random _random = new();

		/// <summary>
		/// Generates a random integer from 0 (inclusive) up to the specified maximum (exclusive)
		/// </summary>
		/// <param name="maxValue">The exclusive upper bound</param>
		/// <returns>A random integer less than maxValue</returns>
		public static int GenerateRandomInt(int maxValue)
		{
			return _random.Next(maxValue);
		}

		/// <summary>
		/// Generates a random double from 0.0 (inclusive) up to the specified maximum (exclusive)
		/// </summary>
		/// <param name="maxValue">The exclusive upper bound</param>
		/// <returns>A random double less than maxValue</returns>
		public static double GenerateRandomDouble(double maxValue)
		{
			return _random.NextDouble() * maxValue;
		}
	}
}
