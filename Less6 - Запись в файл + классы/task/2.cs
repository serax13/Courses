using System;

namespace Lesson6
{
    public class WorldArray
    {
        public string[] array;

        public void Show()
        {
            for (int i = 0; i <= array.Length - 1; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }


    public class Programs
    {
         static void Main(string[] args)
         {
             string[] massiv = new string[2];
             massiv[0] = "1236";
             massiv[1] = "987456";


             WorldArray a2 = new WorldArray();
             a2.array = massiv;
             a2.Show();

             Console.ReadKey();
         }  
    }
}
