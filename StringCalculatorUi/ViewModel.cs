using System.ComponentModel;
using System.Windows.Input;
using StringCalculatorCore;
using StringCalculatorUi.Annotations;

namespace StringCalculatorUi
{
	public class ViewModel : INotifyPropertyChanged
	{
		private string _result;
		private string _text;
		private CalcMode _mode;

		public ViewModel()
		{
			Text = "10,1,2,3";
			Mode = CalcMode.Add;
			Result = "?";
			CalcCommand = new CalcCommand(this);
		}

		public ICommand CalcCommand { get; private set; }

		public string Result
		{
			get { return _result; }
			set
			{
				if (value == _result)
					return;
				_result = value;
				OnPropertyChanged("Result");
			}
		}

		public string Text
		{
			get { return _text; }
			set
			{
				if (value == _text)
					return;
				_text = value;
				OnPropertyChanged("Text");
			}
		}

		public CalcMode Mode
		{
			get { return _mode; }
			set
			{
				if (value == _mode)
					return;
				_mode = value;
				OnPropertyChanged("Mode");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler handler = PropertyChanged;
			if (handler != null)
				handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
