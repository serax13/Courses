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
			string NumberAndText = "1-A,2-B,3-C,4-D,5-E,6-F,7-G";
			int number1 = int.Parse(NumberAndText.Split(',')[0].Replace("-A",""));
			int number2 = int.Parse(NumberAndText.Split(',')[1].Replace("-B",""));
			int number3 = int.Parse(NumberAndText.Split(',')[2].Replace("-C",""));
			int number4 = int.Parse(NumberAndText.Split(',')[3].Replace("-D",""));
			int number5 = int.Parse(NumberAndText.Split(',')[4].Replace("-E",""));
			int number6 = int.Parse(NumberAndText.Split(',')[5].Replace("-F",""));
			int number7 = int.Parse(NumberAndText.Split(',')[6].Replace("-G",""));
		}
	}
}