using System;
using System.Threading;

namespace lesson15
{
	public class User
	{
		public string GetData(string Name, int Age)
		{
			if (Age < 5)
			{
			 return "Privet "+Name+" Vam "+Age+" godikov";	
			}
			else
			return "Privet "+Name+" Vam "+Age+" let";
		}
	}
	
	public class Printer
	{
		public Printer()
		{
			User UserObj = new User();
 			Console.WriteLine(UserObj.GetData("Maks",4));
		}		
	}
		
	
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			Printer PrinterObj = new Printer();
 		}
 	}
} 