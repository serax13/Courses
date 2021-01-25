using System;
using System.Threading;

namespace lesson12
{
class Program
    {
        static string Translate ()
        {
          string Rus = " АБВГДЕЁЖЗИКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
          string En = " ABVGDEEJZIKLMNOPRSTUFHCCSS'Y'EUA";
          string In = "";
          string Out = "";
 
          Console.WriteLine("Введите строку");
          In = Console.ReadLine();
 
            foreach (char Сh in In)
            {
                for (int i = 0; i < Rus.Length; i++)
                {
                    if (Сh == Rus[i])
                    {
                        Out += En[i];
                    }
                }
            }
 
            Console.WriteLine("Транслит");
            for (int i = 0; i < Out.Length; i++)
            {
                Console.Write(Out[i]);
            }
            return Out;
        }
        static void Main(string[] args)
        {
          Translate();  
        }
    }
}

