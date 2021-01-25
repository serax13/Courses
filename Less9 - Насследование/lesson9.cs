using System;

namespace Lesson9
{	
	public class Parser
	{
		public void ParsebyComma(string val)
		{
			string[] arr = val.Split(',');
			for (int i=0;i<arr.Length;i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
		public void ParseBySlash(string val)
		{
			string[] arr = val.Split('|');
			for (int i=0;i<arr.Length;i++)
			{
				Console.WriteLine(arr[i]);
			}
		}

	}
	public class ParseByAmperssand : Parser
	{
		public void ParseAmperssand(string val)
		{
			string[] arr = val.Split('&');
			for (int i=0;i<arr.Length;i++)
			{
				Console.WriteLine(arr[i]);
			}
		}
	}
	public class Lesson9
	{		
		public static void Main(string [] agrs)
		{
			Parser p = new Parser();
			ParseByAmperssand pa = new ParseByAmperssand();
			pa.ParsebyComma("ASD,asd,gasg");
			pa.ParseAmperssand("asd&asd&gasd");
			Console.ReadKey();
			

		}
	}
}