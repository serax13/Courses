using System;

namespace Lesson6
{
    public class Data
        {
            public void Show(string text)
            {
                Console.WriteLine(text);
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
     
    public class User
    {
        public string[] Arr;
        private string Login;
        private string Password;

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public bool IsLogin()
        { 
            Passwords p = new Passwords();
            Arr = p.GetPasswords();
            for (int i = 0; i <= Arr.Length-1; i++)
            {
                if (Arr[i].Split('|')[0].Trim() == Login && Arr[i].Split('|')[1].Trim() == Password)
                {
                    return true;
                }
            }
            return false;    
        }
       
        public string GetUserData()
        {
            bool res = IsLogin();
            
            if(res == true)
            {
                return "Привет Иван";
            }
            else
            {
                return "Неверный логин или пароль!";
            }
        }       
    }

    public class Programs
    {
         static void Main(string[] args)
         {
            User user = new User("ivan","123");
            string resData = user.GetUserData();

            Data d = new Data();
            d.Show(resData);
            Console.ReadKey();
         }  
    }
}
