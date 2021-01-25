using System;

namespace Lesson10
{	
	interface ISomeInterface 
	{
		int property { get; set; }
		void Print ();
	}

	interface IDraw 
	{
		void Draw();
	}

	class Test : ISomeInterface, IDraw
	{
		public int property{ get; set; }
		public void Print ()
		{
			Console.WriteLine("SomeText");
		}
		public void Draw()
		{
			Console.WriteLine("Draw");
		}
	}

	class Test2 : ISomeInterface
	{
		public int property{ get; set; }
		public void Print ()
		{
			Console.WriteLine("SomeText2");
		}
	}
	public class Program
	{	
		public static void Main(string [] agrs)
		{
			Test test_1 = new Test();
			Test2 test_2 = new Test2();
			test_1.property = 12;
			test_1.Print();
			Console.WriteLine(test_1.property);
			test_1.Draw();
		}
	}
}