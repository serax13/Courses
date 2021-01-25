using System;
using System.Threading;

namespace lesson15
{
	public class Percent
	{
		decimal Sum;
		decimal Proc;
		public Percent (decimal Sum1, decimal Proc1)
		{
			 Sum=Sum1;
			 Proc=Proc1;
		}
		public decimal GetDaily()
		{
			return (((Sum/100)*Proc))/12;
		}
			public decimal GetMonthly()
		{
			return ((((Sum/100)*Proc))/12)/30;
		}
	}
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			Percent res = new Percent(500, 10);
 			decimal Res1 = res.GetDaily();
 			decimal Res2 = res.GetMonthly();
 			Console.WriteLine("Дневной процент "+Res1);
 			Console.WriteLine("Месячный процент "+Res2);
 		}
 	}
} 