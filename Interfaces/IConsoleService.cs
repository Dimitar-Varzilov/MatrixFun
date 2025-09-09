namespace MatrixFun.Interfaces
{
    public interface IConsoleService
    {
        int IntRead();
        double DoubleRead();
        string StringRead(string? cancelationString = null, List<string>? stringList = null);
        int ShowMenu(string[] options);
		void ShowWelcomeMessage();
	}
}
