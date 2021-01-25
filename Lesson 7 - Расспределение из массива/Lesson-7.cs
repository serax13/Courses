using System;

namespace Lesson7
{	
	// Класс решает задачу с парсингом string
	// ParseString p = new ParseString("A, 1");
	// p.GetWord(); // Получает A
	// p.GetNumber(); // Полчает 1
	public class ParseString
	{
		public string array;
		
		public ParseString(string value)
		{
			array = value;
		}
		
		public string GetWord()
		{
			return array.Split(',')[0];
		}
		
		public decimal GetNumber()
		{
			return array.Split(',')[1];
		}
	}

	public class Lesson7
	{		
		public static void Main(string [] agrs)
		{
			
		}
	}
}