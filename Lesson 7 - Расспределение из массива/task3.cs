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
			string SumAndText = "1,0-A|2,5-B|3,0-C|4,5-D|6,0-E|10,5-F|25,0-G";
			decimal number1 = decimal.Parse(SumAndText.Split('|')[0].Replace("-A",""));
			decimal number2 = decimal.Parse(SumAndText.Split('|')[1].Replace("-B",""));
			decimal number3 = decimal.Parse(SumAndText.Split('|')[2].Replace("-C",""));
			decimal number4 = decimal.Parse(SumAndText.Split('|')[3].Replace("-D",""));
			decimal number5 = decimal.Parse(SumAndText.Split('|')[4].Replace("-E",""));
			decimal number6 = decimal.Parse(SumAndText.Split('|')[5].Replace("-F",""));
			decimal number7 = decimal.Parse(SumAndText.Split('|')[6].Replace("-G",""));
		}
	}
}