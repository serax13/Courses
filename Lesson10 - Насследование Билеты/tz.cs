using System;

namespace Lesson10
{	
	public class Data
	{
		public string[] GetTicketArr()
		{
			string[] Arr = new string[11];

			Arr[0] = "";
			Arr[1] = "5000 сом | Бишкек - Алмата";
			Arr[2] = "8000 сом | Бишкек - Астана";
			Arr[3] = "15000 сом | Бишкек - Лондон";
			Arr[4] = "25000 сом | Бишкек - Сеул";
			Arr[5] = "7000 сом | Бишкек - Стамбул";
			Arr[6] = "27000 сом | Бишкек - Токио";
			Arr[7] = "6000 сом | Бишкек - Ташкент ";
			Arr[8] = "14000 сом | Бишкек - Санкт-Петербург";
			Arr[9] = "19000 сом | Бишкек - Пекин";
			Arr[10] = "10000 сом | Бишкек - Москва";
			return Arr;
		}
	}

	public class Ticket
	{
			protected decimal GetTotalSum(decimal Sum, byte Way)
			{
				if (Way == 2)
				{
					return Sum*2;
				}
				else
				{
					return Sum;
				}
			}
	}

	public class BuyTicket : Ticket
	{
		public int ticketid;
		public decimal sum;
		public string userName;
		public byte way;
		public string[] array1;

		public BuyTicket(int ticketid, decimal sum, string userName, byte way)
		{
			this.ticketid = ticketid;
			this.sum = sum;
			this.userName = userName;
			this.way = way;
		}

		public void Buy ()
		{
			Data d = new Data();
			string[] Arr1 = d.GetTicketArr();
			for (int i = 1; i < Arr1.Length; i++)
			{
				Console.WriteLine(Arr1[i]);
			}
			Console.WriteLine("ФИО: "+userName);
			for (int i = 1; i < Arr1.Length; i++)
			{
				if (ticketid == i)
				{
					Console.WriteLine("Куда: "+Arr1[i].Split('|')[1]);
					break;
				}
			}  
			if(way == 2)
			{
				Console.WriteLine("Путь: Туда и обратно");
				Console.WriteLine("Сумма к оплате: "+GetTotalSum(sum,way)+" сом");	
			}
			else
			{
				Console.WriteLine("Путь: Один путь");
				Console.WriteLine("Сумма к оплате: "+sum+" сом");
			}		
		}
	}

	public class StampTicket : Ticket
	{
		public int ticketid;
		public byte way1;

		public StampTicket(int ticketid, byte way1)
		{
			this.ticketid = ticketid;
			this.way1 = way1;
		}

		public void Print()
		{
			//Вывод штампа со звездами
			Console.WriteLine();
			string Stars = "*";
			string space = "";
			for(int i = 1; i <= 5; i++)
			{
				space = space+" ";
			}
			for (int i = 0; i < 18; i++)
			{
					Console.Write(Stars);	
			}
			Console.WriteLine();
			Console.WriteLine(Stars+space+"Печать"+space+Stars);
			for (int i = 1; i <= 18; i++)
			{
					Console.Write(Stars);	
			}
			//Вывод вида и суммы билета исходя из ID билета(ticketid).
			Console.WriteLine();
			Data d = new Data();
			string[] Arr1 = d.GetTicketArr();
			if (way1 == 2)
			{
				Console.WriteLine("Вид: Туда и обратно");
				for (int i = 1; i < Arr1.Length; i++)
				{
					if (ticketid == i)
					{
						decimal OnlySum = decimal.Parse(Arr1[i].Split('|')[0].Replace("сом","").Trim());
						Console.WriteLine("Сумма: "+GetTotalSum(OnlySum,way1)+" сом.");
					}
				}
			}
			else
			{
				Console.WriteLine("Вид: В один путь");
				for (int i = 1; i < Arr1.Length; i++)
				{
					if (ticketid == i)
					{
						decimal OnlySum = decimal.Parse(Arr1[i].Split('|')[0].Replace("сом","").Trim());
						Console.WriteLine("Сумма: "+GetTotalSum(OnlySum,way1)+" сом.");
					}
				}	
			}	
		}
	}

	public class Program
	{	
		public static void Main(string [] agrs)
		{
			BuyTicket b = new BuyTicket(1, 5000, "Сергей", 2);
			b.Buy();
			StampTicket stp = new StampTicket(1, 2);
			stp.Print();
		}
	}
}