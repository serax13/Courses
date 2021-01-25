using System;

namespace Lesson7
{	
	public class Data
	{
		public void Print(decimal[] arr3)
		{
		string res = string.Join(",", arr3);
		Console.WriteLine(res);
		}
		public void Print(string[] arr3)
		{
			string res = string.Join(",", arr3);
			Console.WriteLine(res);
		}
		public void Print(string arr3)
		{
				Console.WriteLine(arr3);
		}
	}
	public class ParseArray
	{
		public string array;
		public string[] array1;
		
		public ParseArray(string arr)
		{
			array = arr;
		}
		public ParseArray(string[] arr)
		{
			array1 = arr;
		}
		
		public string[] GetOnlyNames()
		{
			string[] arr2 = new string[array1.Length];
			for (int i = 0; i < array1.Length; i++)
			{
				arr2[i] = array1[i].Split(',')[0].Trim();
			}
			return arr2;
		}

		public decimal[] GetOnlySum()
		{
			decimal[] arr2 = new decimal[array1.Length];
			for (int i = 0; i < array1.Length; i++)
			{
				arr2[i] = decimal.Parse(array1[i].Split(',')[1].Replace("USD","").Trim());
			}
			return arr2;		
		}

		public string[] GetOnlyColors()
		{
			string[] arr2 = new string[array1.Length];
			for (int i = 0; i < array1.Length; i++)
			{
				arr2[i] = array1[i].Split(',')[2].Trim();
			}
			return arr2;
		}
	}

	public class Mass
	{
		public string[] GetCars()
		{
			string[] arrCars = new string [10];
			arrCars[0] = "Мерседес, 2000 USD , Белый";
			arrCars[1] = "Тойота, 2500 USD , Белый";
			arrCars[2] = "Хонда, 5500 USD , Красный";
			arrCars[3] = "Мерседес, 6000 USD , Красный";
			arrCars[4] = "Ауди, 5000 USD , Красный";
			arrCars[5] = "Хонда, 5500 USD , Синий";
			arrCars[6] = "Ниссан, 4200 USD , Красный";
			arrCars[7] = "Мерседес, 5600 USD , Красный";
			arrCars[8] = "Ауди, 7000 USD , Синий";
			arrCars[9] = "Мерседес, 5600 USD , Красный";
			return arrCars;
		}
	}

	public class Counter
	{
		public decimal GetSum(decimal[] arr2)
		{
			decimal Sum = 0;
			decimal SumAll = 0;
			for (int i = 0; i < arr2.Length; i++)
			{
				Sum = arr2[i];
				SumAll = SumAll+Sum;
			}
			Console.WriteLine("Общая сумма: " + SumAll + " USD");
			return SumAll;
		}

		public void GetQuantityColors(string[] arr2)
		{
			int Blue = 0;
			int Red = 0;
			int White = 0;
			for (int i = 0; i < arr2.Length; i++)
			{
				if (arr2[i] == "Синий")
				{
					Blue++;
				}
				if(arr2[i] == "Красный")
				{
					Red++;
				}
				if(arr2[i] == "Белый")
				{
					White++;
				}
			}
			Console.WriteLine("Красный: "+Red+", Синий: "+Blue+", Белый: "+White);		
		}

	}		

	public class Lesson7
	{		
		public static void Main(string [] agrs)
		{
			Mass m = new Mass();
			ParseArray p = new ParseArray(m.GetCars());
			Data d = new Data();
			d.Print(p.GetOnlyNames());
			d.Print(p.GetOnlySum());
			d.Print(p.GetOnlyColors());
		  Counter c = new Counter();
		  c.GetSum(p.GetOnlySum());
		  c.GetQuantityColors(p.GetOnlyColors());

		}
	}
}