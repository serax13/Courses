using System;

namespace Lesson8
{	
	public class TextLibrary
	{
		public void Show (string[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			Console.WriteLine(arr[i]);
		}
		public void Show (string arr)
		{
			Console.WriteLine(arr);
		}
		public void Show (decimal arr)
		{
			Console.WriteLine(arr);
		}
	}
	
			
	public class Lesson8
	{		
		public static void Main(string [] agrs)
		{
			TextLibrary t = new TextLibrary();
			string[] mass = new string [2];
			mass[0] = "asd";
			mass[1] = "asdasd";
			t.Show(123);
			t.Show(mass);
		}
	}
}