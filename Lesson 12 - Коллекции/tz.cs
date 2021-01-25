using System;
using System.Collections.Generic;

namespace Lesson12
{	
	public class Viewer
	{
		public void Show(string text)
		{
			Console.WriteLine(text);
		}
	}

	public class Field : Employee
	{
		public int Id {get;set;}
		public string Name {get;set;}
	}
	
	public class Catalog
	{
		public List<Field> GetCity()
		{
			List<Field> fields = new List<Field>();
			fields.Add( new Field(){ Id = 1, Name = "Бишкек" } );
			fields.Add( new Field(){ Id = 2, Name = "Питер" } );
			fields.Add( new Field(){ Id = 3, Name = "Алмата" } );
			fields.Add( new Field(){ Id = 4, Name = "Ташкент" } );
			fields.Add( new Field(){ Id = 5, Name = "Москва" } );
			return fields;
		}

		public List<Field> GetPositions()
		{
			List<Field> fields = new List<Field>();
			fields.Add( new Field(){ Id = 1, Name = "Директор" } );
			fields.Add( new Field(){ Id = 2, Name = "Программист" } );
			fields.Add( new Field(){ Id = 3, Name = "Тестер" } );
			fields.Add( new Field(){ Id = 4, Name = "PR" } );
			fields.Add( new Field(){ Id = 5, Name = "Консультант" } );
			return fields;
		}

		public List<Field> GetRights()
		{
			List<Field> fields = new List<Field>();
			fields.Add( new Field(){ Id = 1, Name = "Admin" } );
			fields.Add( new Field(){ Id = 2, Name = "User" } );
			return fields;
		}	

		public List<Field> GetEmployee()
		{
			List<Field> fields = new List<Field>();
			fields.Add( new Field(){ Id = 1, Name = "Иван Иванов", CityId = 2, PositionsId = 1, RightsId = 1, Salary = 10000 } );
			fields.Add( new Field(){ Id = 2, Name = "Сергей Коростелев", CityId = 1, PositionsId = 1, RightsId = 1, Salary = 10000 } );
			fields.Add( new Field(){ Id = 3, Name = "Кубат Акматбеков", CityId = 1, PositionsId = 2 , RightsId = 1, Salary = 10000} );
			fields.Add( new Field(){ Id = 4, Name = "Сергей Цой", CityId = 4, PositionsId = 5, RightsId = 2, Salary = 10000 } );
			fields.Add( new Field(){ Id = 5, Name = "Дмитрий Ким", CityId = 3, PositionsId = 4, RightsId = 2, Salary = 10000 } );
			return fields;
		}
	}

	public class Employee
	{
		public int CityId {get;set;}
		public int PositionsId {get;set;}
		public int RightsId {get;set;}
		private decimal salary;
		public decimal Salary
		{
			get
			{
				return salary;
			}
			set
			{
				if(PositionsId == 1)
				{
				 salary = value * 5;
				}
				else if(PositionsId == 2)
				{
				 salary = value * 4.5m;
				}
				else if(PositionsId == 3)
				{
				 salary = value * 2.5m;
				}
				else if(PositionsId == 4)
				{
				 salary = value * 2.3m;
				}
				else if(PositionsId == 5)
				{
				 salary = value * 2;
				}
			}
		}
	}	
	public class Salary
	{
		public void Pay()
		{
			Catalog c = new Catalog();
			List<Field> names = c.GetEmployee();
			List<Field> cities = c.GetCity();
			List<Field> positions = c.GetPositions();
			List<Field> rights = c.GetRights();
			
			foreach(Field n in names)
			{
				Field city = cities.Find(value => value.Id == n.CityId);
				Field pos = positions.Find(value => value.Id == n.PositionsId);
				Field right = rights.Find(value => value.Id == n.RightsId);
				string res = n.Id+" - "+n.Name+", - Адрес: "+city.Name+", - Должность: "+pos.Name+", - "+right.Name+", - Зарплата: "+n.Salary;
				Viewer v = new Viewer();
				v.Show(res);
			}
		}
	}
	public class Lesson12
	{		
		public static void Main(string [] agrs)
		{	
			Salary s = new Salary();
			s.Pay();
			Console.ReadKey();
		}
	}
}