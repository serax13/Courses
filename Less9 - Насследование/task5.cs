using System;
using System.IO;

namespace Lesson9
{	
	public class Calculator
	{
		public int res;
		protected int PercentValue()
		{
			return 100;
		}
		public int Plus(int a,int b)
		{
			res = a + b;
			Console.WriteLine(res);
			return res;
		}
		public int Minus(int a,int b)
		{
			res = a - b;
			Console.WriteLine(res);
			return res;
		}
		public int Umn(int a,int b)
		{
			res = a * b;
			//Console.WriteLine(res);
			return res;
		}
		public int Del(int a,int b)
		{
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
	//Подкласс
	public class PercentCalculator : Calculator
	{
		//Расчет процента
		public void Count()
		{
			Console.WriteLine("Введите процент: ");
			int Proc = int.Parse(Console.ReadLine());
			int Res = (res/PercentValue())*Proc;
			Console.WriteLine("Ваш процент: "+Res);
		} 
	}
	//Подкласс
	public class TimeCalculator : Calculator
	{
		//Расчет недель
		public void GetWeeksInYear(int year)
		{
			Umn(year,365);
			int Week = res/7;
			Console.WriteLine(Week);
		}
	}
	
	public class Lesson9
	{		
		public static void Main(string [] agrs)
		{
			PercentCalculator c = new PercentCalculator();
			TimeCalculator t = new TimeCalculator();
			Console.WriteLine ("Выберите операцию:'+','-','*','/'");
			Console.WriteLine();
			char Choose = char.Parse(Console.ReadLine());
			if (Choose == '+')
			{
				Console.WriteLine ("Введите число 1");
				int a = int.Parse(Console.ReadLine());

				Console.WriteLine ("Введите число 2");
				int b = int.Parse(Console.ReadLine());
				c.Plus(a,b);
			}
			else if (Choose == '-')
			{
				Console.WriteLine ("Введите число 1");
				int a = int.Parse(Console.ReadLine());

				Console.WriteLine ("Введите число 2");
				int b = int.Parse(Console.ReadLine());
				c.Minus(a,b);
			}
			else if
			(Choose == '*')
			{
			Console.WriteLine ("Введите число 1");
				int a = int.Parse(Console.ReadLine());

				Console.WriteLine ("Введите число 2");
				int b = int.Parse(Console.ReadLine());
				Console.WriteLine(c.Umn(a,b));
			}
			else if (Choose == '/')
			{
				Console.WriteLine ("Введите число 1");
				int a = int.Parse(Console.ReadLine());

				Console.WriteLine ("Введите число 2");
				int b = int.Parse(Console.ReadLine());
				c.Del(a,b);
			}
			c.Count();
			Console.WriteLine("Год: ");
			int year = int.Parse(Console.ReadLine());
			Console.WriteLine("Результат кол-ва недель: ");
			t.GetWeeksInYear(year);
		}
	}
}