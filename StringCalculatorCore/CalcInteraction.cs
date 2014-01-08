namespace StringCalculatorCore
{
	public class CalcInteraction
	{
		public string Execute(string text, CalcMode mode)
		{
			int[] numbers = Parser.Split(text);
			int result = Calculator.Execute(numbers, mode);

			return result.ToString();
		}
	}

	//public class CalcInteraction : ICommand
	//{
	//    public event EventHandler CanExecuteChanged;

	//    public void Execute(object param) //String text, CalcMode mode)
	//    {
	//        //int[] numbers = Parser.Split(text);
	//        //int result = Calculator.Execute(numbers, mode);

	//        //return result.ToString();
	//        OnResult(123);
	//    }

	//    public bool CanExecute(object parameter)
	//    {
	//        throw new NotImplementedException();
	//    }
	//}
}
