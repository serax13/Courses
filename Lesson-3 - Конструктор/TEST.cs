using System;
using System.Threading;

namespace lesson15
{
	public class Percent
	{
		public decimal GetDaily(decimal Sum, decimal Proc)
		{
			return (((Sum/100)*Proc))/12;
		}
			public decimal GetMonthly(decimal Sum, decimal Proc)
		{
			return ((((Sum/100)*Proc))/12)/30;
		}
	}
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			Percent res = new Percent();
 			decimal Res1 = res.GetDaily(5000, 10);
 			decimal Res2 = res.GetMonthly(5000, 10);
 			Console.WriteLine("Дневной процент "+Res1);
 			Console.WriteLine("Месячный процент "+Res2);
 		}
 	}
} 