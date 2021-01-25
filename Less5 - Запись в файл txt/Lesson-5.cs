using System;
using System.IO;

namespace Lesson5
{	
	public class Lesson5
	{
		public static void Main(string [] agrs)
		{	
			// Путь файла
			string pathTest = "D:\\Test.txt";
			
			// Текст для записи в файл
			string textTest = "Hello World!";
			
			// Создание файла и запись данных
			File.WriteAllText(pathTest, textTest);
			
			// Тест для записи больших данных в файл
			// Для того что бы использовать отступ используйте Environment.NewLine
			string path = "C:\\BigText.txt";
			string text = "";
			for(int i = 0; i <= 100; i++)
			{
				text += i+" - Hello World! "+DateTime.Now+" "+Environment.NewLine;
			}
			File.WriteAllText(path, text);
			
			// Для получение системную дату
			DateTime date = DateTime.Now;
			Console.WriteLine(date);
						
			// Цифры с прописью
		    string[] numbers10 = new string[21];
			numbers10[1] = "один";
			numbers10[2] = "два";
			numbers10[3] = "три";
			numbers10[4] = "четыре";
			numbers10[5] = "пять";
			numbers10[6] = "шесть";
			numbers10[7] = "семь";
			numbers10[8] = "восемь";
			numbers10[9] = "девять";
			numbers10[10] = "десять";
			numbers10[11] = "одиннадцать";
			numbers10[12] = "двенадцать";
			numbers10[13] = "тринадцать";
			numbers10[14] = "четырнадцать";
			numbers10[15] = "пятнадцать";
			numbers10[16] = "шестнадцать";
			numbers10[17] = "семнадцать";
			numbers10[18] = "восемнадцать";
			numbers10[19] = "девятнадцать";
			numbers10[20] = "двадцать";
			
			string[] numbers100 = new string[110];
			numbers100[10] = "десять";
			numbers100[20] = "двадцать";
			numbers100[30] = "тридцать";
			numbers100[40] = "сорок";
			numbers100[50] = "пятьдесят";
			numbers100[60] = "шестьдесят";
			numbers100[70] = "семьдесят";
			numbers100[80] = "восемьдесят";
			numbers100[90] = "девяносто";
			numbers100[100] = "сто";
			
			// Алгортим 1 - 20
			int number = 88;
			if(number <= 20){
				Console.WriteLine(numbers10[number]);
			}
			
			// Алгоритм 10 - 100
			if(number > 20 && number <= 100){
				int rightSum = number % 10;
				int leftSum = number - rightSum;				
				string result = numbers100[leftSum]+" "+numbers10[rightSum];				
				Console.WriteLine(result);
			}
		}
	}
}