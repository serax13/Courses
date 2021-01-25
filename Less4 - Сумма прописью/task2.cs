using System;
using System.Threading;

namespace lesson15
{

		public class Counter
		{
			public void Count(int x)
			{

				for(int i = 1; i <= x; i++ )
				{
					Thread.Sleep(50);
					Console.WriteLine(i);
			  }
			}
		}
		
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			decimal x = 100 % 10;
 			Console.WriteLine(x);
 			//Counter c = new Counter();
 			//c.Count(10);
 		}
 	}
} 