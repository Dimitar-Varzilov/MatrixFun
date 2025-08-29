using Console_App.Utilities;
using MatrixFun.Utilities;

const int MAX_SIZE = 13;

int size = ConsoleUtilities.IntRead();

int[,] matrix = new int[size, size];

for (int i = 0; i < size; i++)
{
	for (int j = 0; j < size; j++)
	{
		matrix[i, j] = NumberUtilities.GenerateRandomInt(MAX_SIZE);
	}
}