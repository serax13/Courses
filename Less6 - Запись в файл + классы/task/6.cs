using System;
using System.IO;

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
        	for (int i = 0; i <Arr.Length-1; i++)
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
        	   return "Добро пожаловать";
        	}
        	else
        	{
        		return "Неверный логин или пароль!";
        	}
        }
        public void Log()
        {
        	DateTime date = DateTime.Now;
        	string Time1 = date.ToString("yyyy-MM-dd");
        	string Time2 = date.ToString("HH.mm.ss");
        	string FileName = "log_ivan_"+Time1+" "+Time2;
        	string Path = "C:\\Users\\scoi\\Desktop\\C#\\Ноябрь\\Less6\\task\\"+FileName+".txt";
        	string Text = "";
        	Text += "========================Лог пользователя================================"+Environment.NewLine;
        	Text +=" "+Environment.NewLine;
        	Text += "Логин: "+Login+" "+Environment.NewLine;
        	Text += "Пароль: "+Password+" "+Environment.NewLine;
        	bool Res1 = IsLogin();
        	if (Res1 == true)
        	{
        		Text += "Статус входа: Успешный"+" "+Environment.NewLine;
        	}
        	else
        	Text += "Статус входа: Ошибочный"+" "+Environment.NewLine;
        	Text += "Дата входа: "+date.ToString("yyyy-MM-dd")+". "+Environment.NewLine;
        	Text += "Время входа: "+date.ToString("HH:mm:ss")+" "+Environment.NewLine;
        	Text +=" "+Environment.NewLine;
        	File.WriteAllText(Path, Text);
        }

        public void Profile ()
        {
        	DateTime date = DateTime.Now;
        	bool Res = IsLogin();
        	if (Res == true)
        	{
        		Console.ReadLine();
        		Console.WriteLine("1 - Введите адрес по паспорту: ");
        		string AdressPassport = Console.ReadLine();
        		Console.WriteLine("2 - Введите фактический адресс: ");
        		string AdressCurrent = Console.ReadLine();
        		Console.WriteLine("3- Место работы: ");
        		string JobPlace = Console.ReadLine();
        		Console.WriteLine("4 – Возраст: ");
        		byte Age = byte.Parse(Console.ReadLine());
        		Console.WriteLine("5 – Знание языков: ");
        		string Language = Console.ReadLine();
        		Console.WriteLine("6 – Семейное положение: ");
        		string MartialStatus = Console.ReadLine();
        		string Time1 = date.ToString("yyyy-MM-dd");
	        	string Time2 = date.ToString("HH.mm.ss");
	        	string FileName = "Ivanov Ivan"+Time1+" "+Time2;
        		string Path = "C:\\Users\\scoi\\Desktop\\C#\\Ноябрь\\Less6\\task\\"+FileName+".txt";
        		string Text = "";
        		Text += "========================Данные сотрудника================================"+Environment.NewLine;
        		Text +=" "+Environment.NewLine;
        		Text += "-----Адресс по прописке: "+AdressPassport+" "+Environment.NewLine;
        		Text += "----- Фактический адрес: "+AdressCurrent+" "+Environment.NewLine;      	
        		Text += "----- Место работы: "+JobPlace+" "+Environment.NewLine;
        		Text += "----- Возраст:"+Age+" "+Environment.NewLine;
        		Text += "----- Знание языков: "+Language+". "+Environment.NewLine;
        		Text += "----- Семейное положение: "+MartialStatus+". "+Environment.NewLine;
        		Text += "Дата регистрации: "+date.ToString("yyyy-MM-dd")+" "+date.ToString("HH:mm:ss")+" "+Environment.NewLine;
        		Text +=" "+Environment.NewLine;
        		Text += "==========================================================================";
        		File.WriteAllText(Path, Text);
        }
      }

    }

    public class Programs
    {
         static void Main(string[] args)
         {

            Data d = new Data();
            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите Пароль: ");
            string pass = Console.ReadLine();
            User user = new User(login,pass);
            string resData = user.GetUserData();
            d.Show(resData);
            user.Log();
            user.Profile();
            Console.ReadKey();
         }  
    }
}
