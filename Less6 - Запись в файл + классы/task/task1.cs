using System;
using System.Threading;

namespace lesson15
{

		public class World
		{
			public string Name;
			public World (string name)
			{
				Name = name;
			}
			public void Show()
			{
			Console.WriteLine(Name+" World!");
			}
		}
		
		
	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			World c = new World("Hello");
 			c.Show();
 		}
 	}
} 