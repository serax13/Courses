using System;
using System.Collections.Generic;

namespace Lesson11
{	
	
	public class Product
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
	}

	

	public class Lesson11
	{		
		public static void Main(string [] agrs)
		{
			List<Product> products = new List<Product>();
			products.Add(new Product(){Id = 1, Name = "Чай", Price = 50 });
			products.Add(new Product(){Id = 2, Name = "Кофе", Price = 100 });
			products.Add(new Product(){Id = 3, Name = "Сливки", Price = 150 });
			products.Add(new Product(){Id = 4, Name = "Сахар", Price = 40 });
			products.Add(new Product(){Id = 5, Name = "Хлеб", Price = 25 });
			products.Add(new Product(){Id = 6, Name = "Молоко", Price = 60 });
			products.Add(new Product(){Id = 7, Name = "Кефир", Price = 70 });
			products.Add(new Product(){Id = 8, Name = "Сыр", Price = 110 });
			products.Add(new Product(){Id = 9, Name = "Колбаса", Price = 220 });
			products.Add(new Product(){Id = 10, Name = "Масло", Price = 90 });
			foreach (Product product in products)
			{
				Console.WriteLine(product.Id+" "+product.Name+" "+product.Price);
			}
		}
	}
}