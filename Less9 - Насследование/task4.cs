using System;
using System.IO;

namespace Lesson9
{	
	public class Calculator
	{
		public decimal res;
		protected decimal PercentValue()
		{
			return 100;
		}
		public decimal Plus()
		{
			decimal a, b;
			Console.WriteLine ("Введите число 1");
			a = decimal.Parse(Console.ReadLine());

			Console.WriteLine ("Введите число 2");
			b = decimal.Parse(Console.ReadLine());
			res = a + b;
			Console.WriteLine(res);
			return res;
			
		}
		public decimal Minus()
		{
			decimal a, b;
			Console.WriteLine ("Введите число 1");
			a = decimal.Parse(Console.ReadLine());

			Console.WriteLine ("Введите число 2");
			b = decimal.Parse(Console.ReadLine());
			res = a - b;
			Console.WriteLine(res);
			return res;
		}
		public decimal Umn()
		{
			decimal a, b;
			Console.WriteLine ("Введите число 1");
			a = decimal.Parse(Console.ReadLine());

			Console.WriteLine ("Введите число 2");
			b = decimal.Parse(Console.ReadLine());
			res = a * b;
			Console.WriteLine(res);
			return res;
		}
		public decimal Del()
		{
			decimal a, b;
			Console.WriteLine ("Введите число 1");
			a = decimal.Parse(Console.ReadLine());

			Console.WriteLine ("Введите число 2");
			b = decimal.Parse(Console.ReadLine());
			if (b == 0)
			{
				Console.WriteLine("Деление на ноль не возможно!");
			}
			else
			{
				res = a / b;
				Console.WriteLine(res);
				return res;
			}
			return 0;
		}
	}
	public class PercentCalculator : Calculator
	{
		public void Count ()
		{
			Console.WriteLine("Введите процент: ");
			decimal Proc = decimal.Parse(Console.ReadLine());
			decimal Res = (res/PercentValue())*Proc;
			Console.WriteLine(Res);
		} 
	}
	public class Lesson9
	{		
		public static void Main(string [] agrs)
		{
			PercentCalculator c = new PercentCalculator();
			Console.WriteLine ("Выберите операцию:'+','-','*','/'");
			Console.WriteLine();
			char Choose = char.Parse(Console.ReadLine());
			if (Choose == '+')
			{
				c.Plus();
			}
			else if (Choose == '-')
			{
				c.Minus();
			}
			else if
			(Choose == '*')
			{
				c.Umn();
			}
			else if (Choose == '/')
			{
				c.Del();
			}
			c.Count();
		}
	}
}