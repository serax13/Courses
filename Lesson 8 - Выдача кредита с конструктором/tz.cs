using System;

namespace Lesson8
{	
	public class Credit
	{
		string receiverName;
		string receiverAdress;
		string receiverAccount;
		byte receiverAge;
		decimal receiverSum;

		public Credit(string _receiverName, string _receiverAdress,string _receiverAccount, byte _receiverAge, decimal _receiverSum)
		{
			receiverName = _receiverName;
			receiverAccount = _receiverAccount;
			receiverAdress = _receiverAdress;
			receiverAge = _receiverAge;
			receiverSum = _receiverSum;
		}

		public void PrintChek()
		{
			Console.WriteLine("ФИО: "+ receiverName);
			Console.WriteLine("Адресс клиента: "+receiverAdress);
			if(receiverAge < 18)
			{
				TextLibrary text = new TextLibrary();
				text.Show("Вам нет 23.");
				return;
			}
			else if(receiverAge == 18)
			{
				TextLibrary text = new TextLibrary();
				text.Show("Извините, но мы не можем выдать кредит, вам еще нет 18, приходите  через 5лет, что бы получить кредит.");
				return;
			}
			else
			{
				Console.WriteLine("Возраст: "+receiverAge);
			}
			Console.WriteLine("Cчет: "+receiverAccount);
			Console.WriteLine("Сумма кредита: "+receiverSum);

		}
	}
	public class Bank
	{
		string account;
		decimal sum;

		public Bank(string _account, decimal _sum)
		{
			account = _account;
			sum = _sum;
		}
		public string GetAccount()
		{
			return account;
		}

		public decimal GetSum()
		{
			return sum;
		}

	}
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
			Bank b = new Bank("Ivan", 2500);
			t.Show(b.GetAccount());
			t.Show(b.GetSum());
			Credit c = new Credit("Иванов Иван","г. Бишкек","16465465",18,2500);
			c.PrintChek();

		}
	}
}