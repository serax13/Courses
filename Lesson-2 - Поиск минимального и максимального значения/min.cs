using System;
using System.Threading;
namespace Lesson14
{
    public class Lesson11
    {
        static void GetCheaperData(string[] ProductArr,string TextSearch)
        {
            for(int i = 0; i <= ProductArr.Length-1; i++)
            {
                if (ProductArr[i].Contains(TextSearch))
                {
                    decimal min = decimal.Parse(ProductArr[0].Split('-')[0].Replace("$","")); 
                    
                    if (min > decimal.Parse(ProductArr[i].Split('-')[0].Replace("$","")))  
                    {
                        min = decimal.Parse(ProductArr[i].Split('-')[0].Replace("$","")); 
                        Console.WriteLine("Минимальная цена "+ min+"$");
                    }    
                }   
            }
        }    

        static void Main(string[] args)
        {   
            string[] Product = new string[10];
            Product[0] ="4000$-Мерседес";
            Product[1] = "1999$-Мерседес";
            Product[2] = "5646$-Мерседес";
            Product[3] = "7895$-Мерседес";
            Product[4] = "4656$-Мерседес";
            Product[5] = "8895$-Мерседес";
            Product[6] = "9999$-Мерседес";
            Product[7] = "6000$-Мерседес";
            Product[8] = "5999$-Мерседес";
            Product[9] = "12365$-Мерседес";
            GetCheaperData(Product,"Мерседес");        
            Console.ReadKey();
        }
    }   
}   