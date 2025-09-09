namespace MatrixFun.Interfaces
{
	internal interface IExceptionService
	{
		void HandleException<T>(T exception) where T : Exception;
	}
}
