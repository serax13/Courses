using System;
using System.Threading;

namespace lesson4
{
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
                //Услвоие в случае число меньше 20, в текст заносится массив UnitsMass до 19ти
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
                    //Так как массив UnitsMass содержит 20 элеметов от 1 до 19, применяется след. условие
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
        public class lesson4
        {
            public static void Main(string [] args)
            {
                NumbersToWords Obj = new NumbersToWords();
                Console.WriteLine(Obj.Convert(9009));
                Console.ReadKey();            
            }
        }
}    