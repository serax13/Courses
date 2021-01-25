using System;
using System.IO;

namespace Lesson9
{	
	public class FileGenerator
	{
		private string filePathWithName;
		public FileGenerator(string filePathWithName)
		{
			this.filePathWithName = filePathWithName;
		}
		public void Create()
		{
			string Text = "";
			Text += "Файл создан";

			File.WriteAllText(filePathWithName, Text);
		}
	}
	public class Lesson9
	{		
		public static void Main(string [] agrs)
		{
			FileGenerator FG = new FileGenerator("C:\\Users\\scoi\\Desktop\\C#\\Ноябрь\\Less9\\MyFile.txt");
			FG.Create();
			Console.ReadKey();
			

		}
	}
}