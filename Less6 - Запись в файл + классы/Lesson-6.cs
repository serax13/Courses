using System;

namespace Lesson6
{	
	// Пример класса с полями данных
	// Пример использовании класса User
	// User u = new User("Имя");
	// u.Show(); // Результат будет: Имя
	public class User
	{
		// Поля данных
		private string Name;
		
		// Конструктор
		public User(string name)
		{
			// Инитциализация
			Name = name;
		}
		
		// Метод
		public void Show()
		{
			Console.WriteLine(Name);
		}
	}
	
	// Пример вызова полей данных с помощью объекта
	// DataFieldsAge dfa = new DataFieldsAge();
	 //dfa.Age = 10;
	 //dfa.Show(); // Результат будет 10;
	public class DataFieldsAge
	{
		// Поля данных
		public byte Age;
		
		// Метод
		public void Show()
		{
			Console.WriteLine(Age);
		}
	}
	
	// Класс для отображение данных
	//Data d = new Data();
  //d.Show("Привет"); // Результат будет Привет
	public class Data
	{
		public void Show(string text)
		{
			Console.WriteLine(text);
		}
	}
	
	// Класс простого авторизации пользователя
	// Auth a = new Auth("test", "123");
	 //bool resIsLogin = a.IsLogin();
	// string resData = a.GetUserData();
	 //Для отображение используйте класс Data
	// Data d = new Data();
	// d.Show(resIsLogin); // Получает true
	// d.Show(resData);    // Получает Привет тест
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
			DateTime date = DateTime.Now;
			// Вариант 1
			Console.WriteLine(date.Date.ToShortDateString());
			Console.WriteLine(date.Hour);
			Console.WriteLine(date.Minute);
			Console.WriteLine(date.Second);
			
			// Вариант 2 только время
			Console.WriteLine(date.TimeOfDay);
			
			// Вариант 3
			Console.WriteLine(date.ToString("yyyy-MM-dd"));
			Console.WriteLine(date.ToString("HH:mm:ss"));
		}
	}
}