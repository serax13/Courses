using System;
using System.IO;

namespace Lesson5
{
	public class Percent
	{
		public decimal Count(decimal Sum, decimal Proc)
		{
			return (Sum/100)*Proc;
		}
	}

	public class NumbersToWords
	{
		public string Convert(int number)
		{
			if (number == 0)
			return "ноль";

			string Words = "";

			if (number > 0)
			{
				if (Words != "")
				Words += " ";

				var UnitsMass = new[] { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять", "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестьнадцать", "семьнадцать", "восемьнадцать", "девятнадцать" };
				var TensMass = new[] { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
				var HundredsMass = new[] { "", "сто", "двести", "тристо", "четыресто", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
				var ThousandMass = new[] { "", "тысяча", "две тысячи", "три тысячи", "четыре тысячи", "пять тысяч", "шесть тысяч", "семь тысяч", "восемь тысяч", "девять тысяч" };

				if (number < 20 )
				Words += UnitsMass[number];
				else if(number <100)
				{
					Words += TensMass[number / 10];
					if ((number % 10) > 0)
					Words += " " + UnitsMass[number % 10];
				}
				else if (number < 1000)
				{
					Words += HundredsMass[number / 100];
					if ((number % 100) > 0 && (number % 100) < 20)

					Words += " " + UnitsMass[number % 100];
					else    
					{ 
						Words += " " + TensMass[(number % 100)/10];
						Words += " " + UnitsMass[number % 10];
					}    

				}
				else if (number < 10000)
				{
					Words += ThousandMass[number / 1000];
					if ((number % 1000) > 0)
					{   
						Words += " "+HundredsMass[(number % 1000)/100];
						if ((number % 100) > 0 && (number % 100) < 20)
						Words += " " + UnitsMass[number % 100];
						else    
						{ 
							Words += " " + TensMass[(number % 100)/10];
							Words += " " + UnitsMass[number % 10];
						}
					}
				}
			}

			return Words;
		}
	}

	public class Money
	{
		public void Transfer()
		{
			Console.WriteLine("1 - Введите систему отправки: ");
			string PlatejSystema = Console.ReadLine();
			string Path = "C:\\Users\\User\\Desktop\\Lessons\\ноябрь\\Less5-20191112T132327Z-001\\Less5\\"+PlatejSystema+".txt";
			Console.WriteLine("2 - Введите ФИО отправителя: ");
			string Sender = Console.ReadLine();
			Console.WriteLine("3 - Введите адресс отправителя: ");
			string SenderAdress = Console.ReadLine();
			Console.WriteLine("4 - Введите ФИО получателя: ");
			string Recipient = Console.ReadLine();
			Console.WriteLine("5 - Введите адресс получателя: ");
			string RecipientAdress = Console.ReadLine();
			Console.WriteLine("6 - Введите сумму отправки: ");
			int Summ = int.Parse(Console.ReadLine());
			Console.WriteLine("7 - Введите валюту: ");
			string Valuta = Console.ReadLine();
			//Сумма прописью
			NumbersToWords n = new NumbersToWords();
			string ConvertResult = n.Convert(Summ);



			//Подсчет 3 процента от суммы
			Percent p = new Percent();
			decimal Result = p.Count(Summ,3);
			string Text = "";
			Text += "======================== Данные отправителя================================"+Environment.NewLine;
			Text +=" "+Environment.NewLine;
			Text += "ФИО Оправителя: "+Sender+"                Дата отправки:  "+DateTime.Now+" "+Environment.NewLine;
			Text += "Адрес: "+SenderAdress+" "+Environment.NewLine;
			Text += "Cумма отправки: "+Summ+" "+Valuta+" "+Environment.NewLine;
			Text += "Cумма c прописью: "+ConvertResult+". "+Environment.NewLine;
			Text += "Коммисия: "+Result+" "+Valuta+" "+Environment.NewLine;
			Text +=" "+Environment.NewLine;
			Text += "======================== Данные получателя================================"+Environment.NewLine;
			Text +=" "+Environment.NewLine;
			Text += "ФИО Оправителя: "+Recipient+"                Дата отправки:  "+DateTime.Now+" "+Environment.NewLine;
			Text += "Адрес: "+RecipientAdress+" "+Environment.NewLine;
			Text += "Cумма отправки: "+Summ+" "+Valuta+" "+Environment.NewLine;
			Text += "Коммисия: "+Result+" "+Valuta+" "+Environment.NewLine;
			File.WriteAllText(Path, Text);
		}
	}
	public class Lesson5
	{
		public static void Main(string [] agrs)
		{	
			Money Obj = new Money();
			Obj.Transfer();
		}
	}	
}