using System;
using System.Threading;

namespace lesson15
{

		public class Printer
		{
			public void Run(string Text, string Color)
			{
			 if(Color == "Red")
			 {
				 Console.ForegroundColor = ConsoleColor.Red;
				 Console.WriteLine(Text);
				 Console.ResetColor();
			 } 
			 else if(Color == "White")
			 {
				 Console.ForegroundColor = ConsoleColor.White;
				 Console.WriteLine(Text);
				 Console.ResetColor();
			 }
			 else if(Color == "Blue")
			 {
				 Console.ForegroundColor = ConsoleColor.Blue;
				 Console.WriteLine(Text);
				 Console.ResetColor();
			 }
			 else if(Color == "Green")
			 {
				 Console.ForegroundColor = ConsoleColor.Green;
				 Console.WriteLine(Text);
				 Console.ResetColor();
			 }
			 else
			 {
			 	Console.WriteLine(Text);
			 }
			}
			
		}
		
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			Printer c = new Printer();
 			c.Run("Hello Wordl!","White");
 			c.Run("Hello Wordl!","Red");
 			c.Run("Hello Wordl!","Blue");
 			c.Run("Hello Wordl!","Green");
 			c.Run("Hello Wordl!","Yellow");

 		}
 	}
} 