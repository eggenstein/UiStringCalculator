using System;
using System.Globalization;
using System.Windows.Data;
using StringCalculatorCore;

namespace StringCalculatorUi
{
	public class CalcModeConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var mode1 = (CalcMode) value;
			var mode2 = (CalcMode) Enum.Parse(typeof(CalcMode), (string) parameter);

			return (mode1 == mode2);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if ((bool) value == false)
				throw new Exception();

			var mode = (CalcMode) Enum.Parse(typeof(CalcMode), (string) parameter);

			return mode;
		}
	}
}
