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
	public class Auth
	{
		// Поле логин
		private string Login;
		
		// Поле пароль
		private string Password;
		
		// Конструктор
		public Auth(string login, string password)
		{
			Login = login;
			Password = password;
		}
		
		// Метод проверки правильности логина и пароли
		public bool IsLogin()
		{
			if(Login == "test" && Password == "123")
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		// Метод для получение пользовательнских данных
		public string GetUserData()
		{
			// Используем метод
			bool res = IsLogin();
			
			if(res == true)
			{
				return "Привет тест";
			}
			else
			{
				return "Неверный логин или пароль!";
			}
		}		
	}
	
	public class Lesson6
	{		
		public static void Main(string [] agrs)
		{	
			// Класс простой авторизации пользователя
	 Auth a = new Auth("test", "123");
	 bool resIsLogin = a.IsLogin();
	 string resData = a.GetUserData();
	 //Для отображение используйте класс Data
	 Data d = new Data();
	 d.Show(resIsLogin); // Получает true
	 d.Show(resData);    // Получает Привет тест
		}
	}
}