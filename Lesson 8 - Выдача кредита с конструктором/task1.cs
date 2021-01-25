using System;

namespace Lesson7
{	
	public class TestConstructor
	{
		public TestConstructor()
		{
			Console.WriteLine("Hi I am run my constructor first");
		}	
	}
	
			
	public class Lesson7
	{		
		public static void Main(string [] agrs)
		{
			TestConstructor t = new TestConstructor();
		}
	}
}