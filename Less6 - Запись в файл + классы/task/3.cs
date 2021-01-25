using System;

namespace Lesson6
{

    public class Date
    {
        private string Name;
        private byte Age;
        private string Adress;

        public Date (string name, byte age, string adress)
        {
            Name = name;
            Age = age;
            Adress = adress;
        }

        public void Show()
        {
           
                Console.WriteLine("Имя: "+Name);
                Console.WriteLine("Возраст: "+Age);
                Console.WriteLine("Адрес: "+Adress);
         
        }
    }


    public class Programs
    {
         static void Main(string[] args)
         {
             Date d = new Date("Тест", 15, "Тест Адрес");
             d.Show();

             Console.ReadKey();
         }  
    }
}
