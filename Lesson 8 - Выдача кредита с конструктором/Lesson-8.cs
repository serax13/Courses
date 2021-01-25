using System;

namespace Lesson8
{	
	public class Parser
	{
		public char sign = ',';
		
		private string valString;
		
		public Parser(string val)
		{
			valString = val;
		}
		
		public void ShowWithCycle()
		{
			string [] arr = valString.Split(sign);
			for(int i = 0; i <= arr.Length - 1; i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
	
	public class Lesson8
	{		
		public static void Main(string [] agrs)
		{
			
		}
	}
}