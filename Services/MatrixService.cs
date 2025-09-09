using MatrixFun.Constants;
using MatrixFun.Interfaces;
using MatrixFun.Utilities;

namespace MatrixFun.Services
{
	internal class MatrixService : IMatrixService
	{
		private int[,] Matrix = new int[0, 0];
		public int[,] GenerateMatrix(int size)
		{
			Matrix = new int[size, size];
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Matrix[i, j] = NumberUtilities.GenerateRandomInt(MatrixFunConstants.MATRIX_MAX_VALUE);
				}
			}
			return Matrix;
		}
	}
}
