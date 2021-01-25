using System;

namespace Lesson10
{	
	public class Symbol
	{
		public string GetStars()
		{
			return "*";
		}
		public string CreatsteSpace(int count)
		{
			string space = "";
			for(int i = 1; i <= count; i++)
			{
				space = space+" ";
			}
			return space;	
		}
	}
	public class Figure : Symbol
	{

		public void Square(int x, int y)
		{
			for (int i = 1; i <= x; i++)
			{
					Console.Write(GetStars());	
			}
		  
			for (int i = 1; i <= y; i++)
			{
				Console.WriteLine(GetStars() + CreatsteSpace(x-2) + GetStars());
			}
			
			for (int i = 1; i <= x; i++)
			{
					Console.Write(GetStars());	
			}			
		}

		public void Triangle(int x)
		{
			for (int i = 0; i <= x; i++)
			{
				for( int j = 0 ; j < i; j++)
				{
					if (i == 1 && i ==2)
					{
						Console.Write(GetStars());
					}
					if (i > 2 && i < x)
					{
						Console.Write(GetStars()+CreatsteSpace(i-2)+GetStars());
						break;
					}
					else
					{
						Console.Write(GetStars());
					}
				}
				Console.Write("\n");
			}
		}
	}

	public class Program
	{	

		public static void Main(string [] agrs)
		{
			Figure f = new Figure();
			f.Square(6,3);
			f.Triangle(7);
		}
	}
}