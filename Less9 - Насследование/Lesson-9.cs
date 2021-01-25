using System;

namespace Lesson9
{
	public class Parser
	{
		// Класс парсер
		public void ParseByComma(string val)
		{
			string [] res = val.Split(',');
			for(int i = 0; i <= res.Length - 1; i++)
			{
				Console.WriteLine(res[i]);
			}
		}
		
		public void ParseBySlash(string val)
		{
			string [] res = val.Split('|');
			for(int i = 0; i <= res.Length - 1; i++)
			{
				Console.WriteLine(res[i]);
			}
		}
		
		// Этот метод доступен только дочернему классу
		protected decimal GetSum()
		{
			return 100;
		}
	}
	
	// Класс AmpersandParser наследует класс Parser и все методы класса
	public class AmpersandParser : Parser
	{
		public void ParseByAmpersand(string val)
		{
			decimal sum = GetSum();
			string [] res = val.Split('&');
			for(int i = 0; i <= res.Length - 1; i++)
			{
				Console.WriteLine(res[i]);
			}
		}
	}
	
	public class Lesson8
	{		
		public static void Main(string [] agrs)
		{
			AmpersandParser a = new AmpersandParser();
			a.ParseByAmpersand("1&2&3&4&5&4");
			a.ParseByComma("2,2,3,4,4,5");
		}
	}
}