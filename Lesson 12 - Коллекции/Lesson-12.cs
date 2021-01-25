using System;
using System.Collections.Generic;

namespace Lesson12
{	
	public class Data
	{
		public int Id {get; set;}
		public string Name {get; set;}
	}

	public class Lesson12
	{		
		public static List<Data> GetData()
		{
			List<Data> data = new List<Data>();
			data.Add( new Data(){ Id = 1, Name = "A" } );
			data.Add( new Data(){ Id = 2, Name = "B" } );
			return data;
		}
		public static void Main(string [] agrs)
		{
			List<Data> data = GetData();
			
			Data res = data.Find(x => x.Id == 1);
			res.Name = "C";
			
			foreach(Data d in data)
			{
				Console.WriteLine(d.Id+" "+d.Name);
			}
		}
	}
}