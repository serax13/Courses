using System;
using System.Collections.Generic;

namespace Lesson11
{	
	public class Product
	{
		public long Id {get; set;}
		public string Name { get; set;}
		public decimal Price {get; set;}
	}

	public class CarShop: Product
	{
		public string Year {get; set;}
		public int CountryId { get; set;}
		public string Color {get; set;}
	}

	public class Lesson11
	{		
		public static void Main(string [] agrs)
		{
			List<CarShop> cars = new List<CarShop>();
			cars.Add(new CarShop(){Id = 1, Name = "Мерседес", Price = 5000, Year = "1999", CountryId = 1, Color = "Black" });
			cars.Add(new CarShop(){Id = 2, Name = "Тойота", Price = 10000, Year = "2009", CountryId = 2, Color = "White" });
			cars.Add(new CarShop(){Id = 3, Name = "Хонда", Price = 8500, Year = "2008", CountryId = 2, Color = "Blue" });
			cars.Add(new CarShop(){Id = 4, Name = "БМВ", Price = 14000, Year = "2005", CountryId = 1, Color = "Black" });
			cars.Add(new CarShop(){Id = 5, Name = "Вольво", Price = 6000, Year = "2002", CountryId = 1, Color = "Red" });
			cars.Add(new CarShop(){Id = 6, Name = "Мерседес", Price = 6700, Year = "2001", CountryId = 1, Color = "Green" });
			cars.Add(new CarShop(){Id = 7, Name = "Ниссан", Price = 7000, Year = "2005", CountryId = 2, Color = "White" });
			cars.Add(new CarShop(){Id = 8, Name = "Форд", Price = 1100, Year = "1996", CountryId = 1, Color = "Blue" });
			cars.Add(new CarShop(){Id = 9, Name = "Тойота", Price = 2200, Year = "1995", CountryId = 2, Color = "Grey" });
			cars.Add(new CarShop(){Id = 10, Name = "Ауди", Price = 9000, Year = "2004", CountryId = 1, Color = "Black" });
			foreach (CarShop car in cars)
			{
				Console.WriteLine(car.Id+" "+car.Name+" "+car.Price);
			}
		}
	}
}