using System;

namespace Lesson10
{	
	public class Symbol
	{
		public string GetStars()
		{
			return "*";
		}
		public string CreatsteSpace(int x)
		{
			string space = "";
			for(int i = 0; i <= x; i++)
			{
				space = space+" ";
			}
			return space;	
		}
	}
	public class Program
	{		
		public static void Main(string [] agrs)
		{
			Symbol s = new Symbol();
			Console.Write(s.CreatsteSpace(5));
			Console.Write(s.GetStars());
		}
	}
}