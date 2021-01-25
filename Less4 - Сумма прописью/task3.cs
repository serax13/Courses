using System;
using System.Threading;

namespace lesson15
{

		public class Figure
		{
			public void Draw(int x)
			{	
				int n = 1;
				for(int i = 1; i <= x; i++)
				{
					Console.Write("*");
					n++;
					if(n > 5)
					{
						n = 1;
						Console.Write("\n");
					}
					Thread.Sleep(50);
				}
			}
		}
		
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			Figure c = new Figure();
 			c.Draw(30);
 		}
 	}
} 