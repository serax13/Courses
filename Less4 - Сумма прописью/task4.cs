using System;
using System.Threading;

namespace lesson15
{

		public class Figure
		{
			public void Draw(int x)
			{	
				for(int i = 1; i <= x; i++)
				{
					Console.Write("*");
					Thread.Sleep(50);
				}
				Console.Write("\n");
				Console.ResetColor();
			}
			
		}
		public class FigureWithColors
		{
			public void DrawColor()
			{
				Figure f = new Figure();
				Console.ForegroundColor = ConsoleColor.Red;
				f.Draw(10);
				Console.ForegroundColor = ConsoleColor.Blue;
				f.Draw(10);
				Console.ForegroundColor = ConsoleColor.Green;
				f.Draw(10);
			}
		}
		
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			FigureWithColors c = new FigureWithColors();
 			c.DrawColor();
 		}
 	}
} 