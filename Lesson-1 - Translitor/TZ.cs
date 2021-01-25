using System;
using System.Threading;

namespace lesson13
{
  public class lesson13
  {
    public static string Translit()
    {   
        Console.WriteLine("Введите текст: ");
        string Text = Console.ReadLine();
        string[] RusUp = {"А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я"};
        string[] RusLow = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я"};
        string[] EngUp = {"A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "Kh", "Ts", "Ch", "Sh", "Shch", "", "Y", "'", "E", "Yu", "Ya"};
        string[] EngLow = {"a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch", "", "y", "'", "e", "yu", "ya"};
        for (int i = 0; i <= 32; i++)
        {
            Text = Text.Replace(RusUp[i],EngUp[i]);
            Text = Text.Replace(RusLow[i],EngLow[i]);              
        }
        Console.WriteLine(Text);
        return Text;
    }    

    public static void Main(string [] args)
    {
        while (true) 
        {
           Translit();
        Console.ReadKey(); 
        }
    }
    }
 }

