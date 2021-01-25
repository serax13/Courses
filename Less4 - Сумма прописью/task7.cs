using System;
using System.Threading;

namespace lesson15
{

		public class ShowArrays
		{
			public ShowArrays(string[] ArrString)
			{
				for(int i = 0; i <= ArrString.Length-1; i++)
				Console.WriteLine(ArrString[i]);
			}
			public ShowArrays(decimal[] ArrDecimal)
			{
				for(int i = 0; i <= ArrDecimal.Length-1; i++)
				Console.WriteLine(ArrDecimal[i]);
			}
			public ShowArrays(int[] ArrInt)
			{
				for(int i = 0; i <= ArrInt.Length-1; i++)
				Console.WriteLine(ArrInt[i]);
			}
		}

	public class lesson15
	{
		public static void Main(string [] args)
 		{
 			string[] Arr1 = new string[3];
 			Arr1[0] = "asd";
 			Arr1[1] = "asd";
 			Arr1[2] = "gsdg";

 			decimal[] Arr2 = new decimal[3];
 			Arr2[0] = 21441;
 			Arr2[1] = 15351;
 			Arr2[2] = 5152;

 			int[] Arr3 = new int[3];
 			Arr3[0] = 1;
 			Arr3[1] = 2;
 			Arr3[2] = 3;
			
 			ShowArrays Obj = new ShowArrays(Arr1);
 			Console.ReadKey();
 		}
 	}
} 