using System.Linq;

namespace StringCalculatorCore
{
	public class Parser
	{
		public static int[] Split(string text)
		{
			string[] parts = text.Split(',');

			return parts.Select(int.Parse).ToArray();
		}
	}
}
