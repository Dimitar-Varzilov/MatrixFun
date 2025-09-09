using MatrixFun.Enums;
using MatrixFun.Interfaces;

namespace MatrixFun.Services
{
	internal class SettingsService : ISettingsService
	{
		private Algorithm ChosenAlgorithm;
		public Algorithm SetChosenAlgorithm(int algorithm)
		{
			return ChosenAlgorithm = (Algorithm)algorithm;
		}
	}
}
