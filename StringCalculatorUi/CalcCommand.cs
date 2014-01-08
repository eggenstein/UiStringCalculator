using System;
using System.Windows.Input;
using StringCalculatorCore;

namespace StringCalculatorUi
{
	public class CalcCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;

		private ViewModel _vm;

		public CalcCommand(ViewModel vm)
		{
			_vm = vm;
		}

		public void Execute(object parameter)
		{
			var ci = new CalcInteraction();
			_vm.Result = ci.Execute(_vm.Text, _vm.Mode);
		}

		public bool CanExecute(object parameter)
		{
			return true;
		}
	}
}
