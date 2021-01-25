using System;

namespace Lesson8
{	
	public class User
	{
		private string name;
		private string adress;
		private byte age;

		public User(string _name, string _adress, byte _age)
		{
			name = _name;
			adress = _adress;
			age = _age;
		}


		public string GetName()
		{
			return name;
		}

		public string GetAdress()
		{
			return adress;
		}

		public byte GetAge()
		{
			return age;
		}
	}
	
	public class TextLibrary
	{
		private void Show (string[] arr)
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
			User user = new User("Иванов Иван", "г. Бишкек", 25);
			t.Show(user.GetName());
			t.Show(user.GetAdress());
			t.Show(user.GetAge());
		}
	}
}