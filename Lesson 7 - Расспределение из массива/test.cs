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
			string number = "1,2,3,4,5,6,6,7,8,9,10";
			int number1 = int.Parse(number.Split(',')[0]);
			int number2 = int.Parse(number.Split(',')[1]);
			int number3 = int.Parse(number.Split(',')[2]);
			int number4 = int.Parse(number.Split(',')[3]);
			int number5 = int.Parse(number.Split(',')[4]);
			int number6 = int.Parse(number.Split(',')[5]);
			int number7 = int.Parse(number.Split(',')[6]);
			int number8 = int.Parse(number.Split(',')[7]);
			int number9 = int.Parse(number.Split(',')[8]);
			int number10 = int.Parse(number.Split(',')[9]);

		}
	}
}