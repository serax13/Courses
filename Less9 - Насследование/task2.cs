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
	public class FileFactory
	{
		private int FileQuantity;
		private string FilePath;
		private string FilePrefix;
		
	
		public FileFactory(int FileQuantity, string FilePath, string FilePrefix )
		{
			this.FileQuantity = FileQuantity;
			this.FilePath = FilePath;
			this.FilePrefix = FilePrefix;
		}
		public void Run()
		{
			for(int i = 1; i <= FileQuantity; i++)
			{
				FileGenerator FG = new FileGenerator(FilePath+"\\"+FilePrefix+"_"+i+".txt");
				FG.Create();
			}
		}
	}
	public class Lesson9
	{		
		public static void Main(string [] agrs)
		{
			FileFactory FF = new FileFactory(3, "C:\\Users\\scoi\\Desktop\\C#\\Ноябрь\\Less9\\", "MyFile.txt" );
			FF.Run();
		}
	}
}