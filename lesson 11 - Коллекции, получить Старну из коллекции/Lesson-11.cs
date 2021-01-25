using System;
using System.Collections.Generic;

namespace Lesson11
{	
	// Свойства с модификаторами доступа
	// User1 u = new User1();
	// u.Age = 23;
	// u.Name = "Иванов Иван";
	// Будет работать так как поля доступны внутри класса
	// u.GetData();
	// Будет ошибка так как поля доступны только для записи
	// Console.WriteLine(u.Age+" "+u.Name);
	public class User1
	{
		public int Age {private get; set;}
		
		public string Name {private get; set;}
		
		public void GetData()
		{
			Console.WriteLine(Age+" "+Name);
		}
	}
	
	// Автоматические свойства
	// User2 u = new User2();
	// u.Age = 23;
	// u.Name = "Иванов Иван";			
	// Будет работать так как поля доступны внутри класса
	// u.GetData();
	// Будеть работать так как все поля автоматически доступны и для записи для чтнение
	// Console.WriteLine(u.Age+" "+u.Name);
	public class User2
	{
		public int Age {get; set;}
		public string Name {get; set;}
		
		public void GetData()
		{
			Console.WriteLine(Age+" "+Name);
		}
	}
	
	// Класс с свойствами для использование в коллеции
	public class User
	{
		public int Id {get; set;}
		public int Age {get; set;}
		public string Name {get; set;}
	}

	public class Lesson11
	{		
		public static void Main(string [] agrs)
		{
			// =========================== Тип значении ==================================== //
			
			// Простое использование коллекции с типом значении string
			List<string> names = new List<string>();
			names.Add("Привет 1");
			names.Add("привет 2");
			// Console.WriteLine("Без цикла: "+names[0]);
			// Console.WriteLine("Без цикла: "+names[1]);
			
			// Пример вывода с помощью цикла for
			for(int i = 0; i<= names.Count - 1; i++)
			{
				// Console.WriteLine("for: "+names[i]);
			}
			
			// Пример вывода с помощью цикла foreach
			foreach(string name in names)
			{
				// Console.WriteLine("foreach: "+name);
			}
			
			// ============================ Ссылочный тип =================================== //
			
			// Пример коллекции с ссылочным типом User
			List<User> users = new List<User>();
			users.Add( new User() { Id = 1, Age = 20, Name = "Айзада Жумакадырова" } );
			users.Add( new User() { Id = 2, Age = 23, Name = "Сергей Коростелев" } );
			users.Add( new User() { Id = 3, Age = 30, Name = "Кубат Акматбеков" } );
			users.Add( new User() { Id = 4, Age = 50, Name = "Цой Сергей" } );
			
			// ============ Лямбда выражаение и использование метода Find =================== //
			
				// => Назвается лямбда выражения
				// Глубже будем рассматривать потом
				// data => data.Id = 1 Это как
				// User user = new User();
				// user.Id = 1
				// Здесь говорится что нужно найти пользователя с Id = 1
				User user1 = users.Find(data => data.Id == 1);
				User user2 = users.Find(data => data.Id == 2);
				Console.WriteLine(user1.Age+" "+user1.Name);
				Console.WriteLine(user2.Age+" "+user2.Name);
				
			// ============================================================================== //
			
			// Пример вывода с помощью цикла for
			for(int i = 0; i<= users.Count - 1; i++)
			{
				// Console.WriteLine("for: "+users[i].Id+" Возраст: "+users[i].Age+" ФИО: "+users[i].Name);
			}
			
			// Пример вывода с помощью цикла foreach
			foreach(User user in users)
			{
				 Console.WriteLine("foreach: "+user.Id+" Возраст: "+user.Age+" ФИО: "+user.Name);
			}
		}
	}
}