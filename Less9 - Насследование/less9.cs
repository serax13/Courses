using System;

namespace Lesson9
{	
	class Animal
	{
		public string Name {get; set;}
	}
	class Dog : Animal 
	{
		
	}
	public class Lesson9
	{		
		public static void Main(string [] agrs)
		{
			Dog tom = new Dog();
			tom.Name = "Том";
			Console.WriteLine(tom.Name);
			Console.ReadKey();

		}
	}
}