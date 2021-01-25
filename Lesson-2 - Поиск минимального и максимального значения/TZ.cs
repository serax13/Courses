using System;
using System.Threading;

namespace Lesson11
{
	public class Lesson11
	{	
		static decimal Max(decimal[] array)    
    {
     	decimal min = array[0];
      for (int i = 0; i < array.Length; i++) 
      {
      	if (min > array[i])  
        {
        	min = array[i]; 
        }
      }
      return min;        
    }    
		static void GetCheaperData(string[] ProductArr, string TextSearch)
		{

			for(int i = 0; i <= 2; i++)
			
			{
				if (ProductArr[i].Contains(TextSearch) == true)
				{
					decimal[] CheaperPrice = new decimal[3];
					CheaperPrice[i] = decimal.Parse(ProductArr[i].Split('-')[0].Replace("$",""));
					decimal Min = Max(CheaperPrice);
					Console.WriteLine(Min);
				}
			}
		}	
		public static void Main(string [] agrs)
		{
			string[] ProductArr = new string[] {"4000$-Мерседес", "2500$-Мерседес", "5000$-Мерседес"};


			GetCheaperData(ProductArr,"Мерседес");

			Console.ReadKey();
		}
	}	
}	