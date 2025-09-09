using MatrixFun.Constants;
using MatrixFun.Enums;
using MatrixFun.Interfaces;

namespace MatrixFun.Services;

internal class MatrixGameService(
    IMatrixService matrixService,
    ISettingsService settingsService,
    IExceptionService exceptionService,
    IConsoleService consoleService) : IMatrixGameService
{
    public void Run()
    {
        try
        {
            Thread.Sleep(200);
            consoleService.ShowWelcomeMessage();

            Console.WriteLine("Please input the size of the matrix:");
            int size = consoleService.IntRead();

            Console.WriteLine("Matrix is being created... Hold still :)");

            int[,] matrix = matrixService.GenerateMatrix(size);
            Console.WriteLine("Matrix IsFixedSize: {0}", matrix.Length);
            Console.WriteLine("Matrix successfully generated!");

            Console.WriteLine("Please choose the algorithm for identifying clusters with same value and press Enter:");
            string[] algorithms = MatrixFunConstants.Algorithms;
            int selectedAlgorithm = consoleService.ShowMenu(algorithms);
            Algorithm algorithm = settingsService.SetChosenAlgorithm(selectedAlgorithm);
            Console.WriteLine($"Selected: {algorithms[selectedAlgorithm]}");

            Console.WriteLine("Starting identifying clusters with same value...");
            switch (algorithm)
            {
                case Algorithm.DFS:
                    break;
                case Algorithm.BFS:
                    break;
                case Algorithm.UnionFind:
                    break;
                case Algorithm.None:
                default:
                    throw new ApplicationException("No algorithm selected or wrong algorithm provided.");
            }
        }
        catch (Exception ex)
        {
            exceptionService.HandleException(ex);
        }
    }
}