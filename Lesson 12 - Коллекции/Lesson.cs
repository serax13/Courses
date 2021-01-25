using System;
using System.Collections.Generic;

namespace Lesson12
{
	public class User
	{
		public int Id {get; set;}
		public string Name {get; set;}
	}
	
	public class Lesson12
	{
		public static string GetData()
		{
			string res = "test";
			return res;
		}
		
		public static User GetUser()
		{
			User user = new User();
			user.Id = 1;
		`	user.Name = "Test";
			return user;
		}
		
		public static void WriteText(string text)
		{
			string res = "Text: "+text;
			Console.WriteLine(res);
		}
		
		public static void WriteUser(User user)
		{
			Console.WriteLine(user.Id+" "+user.Name);
		}
		
		public static void Main(string [] agrs)
		{
			string res = GetData();
			Console.WriteLine(res);
			
			User user = GetUser();
			WriteUser(user);
			
			WriteText("Test");
		}
	}
}