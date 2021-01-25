using System;

namespace Lesson7
{	
	// Класс решает задачу с парсингом string
	// ParseString p = new ParseString('A, 1');
	// p.GetWord(); // Получает A
	// p.Getnumber(); // Полчает 1


	public class Lesson7
	{		
		public static void Main(string [] agrs)


		{
			string[] arr = {"1-A", "2-B", "3-C", "4-D", "25-Z"};
			for (int i = 0; i < arr.Length; i++)
			{
				Console.WriteLine ("Номер "+arr[i].Split('-')[0]);
			}
		}
	}
}