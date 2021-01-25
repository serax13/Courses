using System;
using System.Threading;

namespace lesson15
{
	public class Calculator
	{
		public decimal Plus(decimal x,decimal y)
		{
			return x + y;
		}
			public decimal Minus(decimal x,decimal y)
		{
			return x - y;
		}
	}
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			Calculator calc = new Calculator();
 			decimal Res = calc.Plus(1,5);
 			Console.WriteLine(Res);
 		}
 	}
} 