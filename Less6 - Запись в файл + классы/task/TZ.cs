using System;
using System.IO;

namespace Lesson6
{
    public class User
    {
        private string login;
        private string password;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }
        public bool IsLogin()
        {
            Passwords passwords = new Passwords();
            string[] array= passwords.GetPasswords();
            for (int i=0;i< array.Length; i++)
            {
                if (array[i].Contains(this.login) && array[i].Contains(this.password))
                {
                    return true;
                } 
            }
            return false;
        }
        public string GetUserData()
        {
            Passwords passwords = new Passwords();
            string[] array = passwords.GetPasswords();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains(this.login) && array[i].Contains(this.password))
                {
                    return array[i];
                }
            }
            return "Неправильный логин или пароль!";

        }
        public string GetUserName()
        {
            Passwords passwords = new Passwords();
            string[] array = passwords.GetPasswords();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Contains(this.login) && array[i].Contains(this.password))
                {
                    return array[i].Split('|')[2].Trim();
                }
            }
            return "";
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
            passwordsArr[10] = "ivan | 173 | Иванов Иван";
            passwordsArr[11] = "ivan | 124 | Иванов Иван";
            passwordsArr[12] = "ivan | 129 | Иванов Иван";
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
        static void PrintToLogFile(string login, string password,bool isLogin)
        {

            DateTime date = DateTime.Now;
            string ok;
            if (isLogin == true)
            {
                ok = "Успешный вход";
            }
            else 
            {
                ok = "Ошибочный";
            }
            string pathTest = "C:\\log_" + login + "_"+ date.ToString("yyyy-MM-dd") +" "+ date.ToString("HH_mm_ss") +".txt";
            string text = "=======================Лог пользователя " + Environment.UserName + "===========================" + Environment.NewLine +
                "\t\tЛогин: " + login + Environment.NewLine +
                "\t\tПароль: " + password + Environment.NewLine +
                "\t\tСтатус входа: " +ok+ Environment.NewLine +
                "\t\tДата входа: " + date.ToString("yyyy-MM-dd") + Environment.NewLine +
                "\t\tВремя входа: " + date.ToString("HH:mm:ss") + Environment.NewLine +
                "========================================================================";
            File.WriteAllText(pathTest, text);
        }


        static void PrintToDataFile(string userName, string adressID,string adressPlace,string placeWork, string age,string language,string familyStatus)
        {
            DateTime date = DateTime.Now;
            string pathTest = "C:\\" + userName + "_" + date.ToString("yyyy-MM-dd") + " " + date.ToString("HH_mm_ss") + ".txt";
            string text = "=================================Данные сотрудника " + userName + "======================================" + Environment.NewLine +
                "\t\t----- Адрес по прописке:" + adressID + Environment.NewLine +
                "\t\t----- Фактический адрес: " + adressPlace + Environment.NewLine +
                "\t\t----- Место работы: " + placeWork + Environment.NewLine +
                "\t\t----- Возраст: " + age + Environment.NewLine +
                "\t\t----- Знание языков: " + language + Environment.NewLine +
                "\t\t----- Семейное положение: " + familyStatus + Environment.NewLine +
                "Дата регистрации: "+ date.ToString("yyyy-MM-dd") +" " + date.ToString("HH:mm:ss") + Environment.NewLine +
                "===================================================================================================";
            File.WriteAllText(pathTest, text);
        }
        static void Main(string[] args)
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Введите логин:");
            string login=Console.ReadLine();
            Console.WriteLine("Введите пароль:");
            string password = Console.ReadLine();
            User user = new User(login, password);

            bool isLogin = user.IsLogin(); 
            PrintToLogFile(login, password, isLogin); 
            if (isLogin== true)
            {
                Console.WriteLine("Добро пожаловать " + user.GetUserName() + "!");
                Console.WriteLine("1 - Введите адрес по паспорту:");
                string adressID =Console.ReadLine();
                Console.WriteLine("2- Введите фактический адрес: ");
                string adressPlace =Console.ReadLine();
                Console.WriteLine("3- Место работы: ");
                string placeWork =Console.ReadLine();
                Console.WriteLine("4 – Возраст: ");
                string age =Console.ReadLine();
                Console.WriteLine("5 – Знание языков: ");
                string language =Console.ReadLine();
                Console.WriteLine("6 – Семейное положение: ");
                string familyStatus =Console.ReadLine();
                PrintToDataFile(user.GetUserName(), adressID, adressPlace, placeWork, age, language, familyStatus);
            }

            Console.ReadKey();
        }

    }
}