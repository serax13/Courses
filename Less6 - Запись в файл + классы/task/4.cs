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

    public class Passwords
    {
        public string[] GetPasswords()
        {
             string[] passwordsArr = new string[20];
             passwordsArr[0] = "ivan | 123 | Иванов Иван";
             passwordsArr[1] = "sergei | abs | Сергей Костюков";
             passwordsArr[2] = "sergei | abs | Сергей Костюков";
             passwordsArr[3] = "sergei | abs | Сергей Костюков";
             passwordsArr[4] = "sergei | abs | Сергей Костюков";
             passwordsArr[5] = "sergei | abs | Сергей Костюков";
             passwordsArr[6] = "sergei | abs | Сергей Костюков";
             passwordsArr[7] = "sergei | abs | Сергей Костюков";
             passwordsArr[8] = "sergei | abs | Сергей Костюков";
             passwordsArr[9] = "sergei | abs | Сергей Костюков";
             passwordsArr[10] = "ivan | 123 | Иванов Иван";
             passwordsArr[11] = "ivan | 123 | Иванов Иван";
             passwordsArr[12] = "ivan | 123 | Иванов Иван";
             passwordsArr[13] = "ivan | 123 | Иванов Иван";
             passwordsArr[14] = "ivan | 123 | Иванов Иван";
             passwordsArr[15] = "ivan | 123 | Иванов Иван";
             passwordsArr[16] = "ivan | 123 | Иванов Иван";
             passwordsArr[17] = "ivan | 123 | Иванов Иван";
             passwordsArr[18] = "ivan | 123 | Иванов Иван";
             passwordsArr[19] = "ivan | 123 | Иванов Иван";
        return passwordsArr;
        }
    }


    public class Programs
    {
         static void Main(string[] args)
         {


             Passwords p = new Passwords();


             WorldArray w = new WorldArray();


             w.array = p.GetPasswords();
             w.Show();
             Console.ReadKey();
         }  
    }
}
