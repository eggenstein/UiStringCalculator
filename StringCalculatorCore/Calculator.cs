using System.Linq;

namespace StringCalculatorCore
{
	public class Calculator
	{
		public static int Sum(int[] numbers)
		{
			return numbers.Sum();
		}

		public static int Execute(int[] numbers, CalcMode mode)
		{
			if (mode == CalcMode.Add)
				return Sum(numbers);

			if (mode == CalcMode.Subtract)
				return Subtract(numbers);

			return 0;
		}

		private static int Subtract(int[] numbers)
		{
			if (numbers.Length == 0)
				return 0;

			if (numbers.Length == 1)
				return numbers[0];

			int subSum = 0;
			for (int i = 1; i < numbers.Length; i++)
			{
				subSum += numbers[i];
			}

			return numbers[0] - subSum;
		}
	}
}
