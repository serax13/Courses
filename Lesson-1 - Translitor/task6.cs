using System;
using System.Threading;

namespace Lesson11
{
	public class Lesson11
	{		
		static void Stars ()
		{
			int n = 1;
			Console.WriteLine("Введите количество символов: ");
			int Star = int.Parse(Console.ReadLine());
			Console.WriteLine("Введите количество строк: ");
			int Stroka = int.Parse(Console.ReadLine());
			int Count = Star*Stroka;
			for(int i = 1; i <= Count; i++)
			{
				Console.Write("*");
				n++;
				if(n > Star)
				{
					n = 1;
					Console.Write("\n");
				}
				Thread.Sleep(100);
			}
		}
		public static void Main(string [] agrs)
		{
			Stars ();
		}
	}	
}	