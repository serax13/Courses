using System;

namespace Lesson8
{	
	public class TestField
	{
		private string val;
		public TestField(string _val)
		{
			val = _val;
		}
		public void Show ()
		{
			Console.WriteLine(val);
		}
	
		
	}
	
			
	public class Lesson8
	{		
		public static void Main(string [] agrs)
		{
			TestField t = new TestField("asd");
			t.Show();
		}
	}
}