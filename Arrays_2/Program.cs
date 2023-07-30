using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region ARRAY
			/*
			//int[] arr = new int[] { 3, 5, 8, 13, 21 };
			Console.WriteLine("Введите размер массива: ");
			int n = Convert.ToInt32(Console.ReadLine());
			//int[] arr = new int[n];
			int[] arr;
			arr = new int[n];
			
			//Заполнение массива случайными числами:
			//1)Создаём объект класса Random:
			Random rand = new Random(0);
			for(int i = 0; i < arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}
			//Вывод массива на экран:

			for(int i = 0; i < arr.Length; i++)
			{
				Console.Write(arr[i] + "\t");
			}
			Console.WriteLine();
			Console.WriteLine($"Сумма элементов массива: {arr.Sum()}");
			Console.WriteLine($"Средне-арифметическое элементов массива: {arr.Average()}");
			Console.WriteLine($"Минимальное значение в массиве: {arr.Min()}");
			Console.WriteLine($"Максимальное значение в массиве: {arr.Max()}");

			Array.Sort(arr);

			foreach(int i in arr)
			{
				Console.Write(i + "\t");
			}
			Console.WriteLine();

			arr = arr.Concat(new int[] { 123 }).ToArray();
			foreach(int i in arr) Console.Write(i + "\t"); Console.WriteLine();
			*/
			#endregion ARRAY

			#region ARRAY_2
			/*
			//Console.Write("Введите количество строк: ");
			//int rows = Convert.ToInt32(Console.ReadLine());
			//Console.Write("Введите количество элементов строки: ");
			//int cols = Convert.ToInt32(Console.ReadLine());

			//int[,] i_arr_2 = new int[rows,cols];
			int[,] i_arr_2 = new int[,]
			{
				{1, 2, 3 },
				{4, 5, 6 },
				{7, 8, 9 },
			};
			Console.WriteLine(i_arr_2.Length);
			Console.WriteLine(i_arr_2.Rank);
			Console.WriteLine(i_arr_2.GetLength(0));
			Console.WriteLine(i_arr_2.GetLength(1));
			Random rand = new Random(0);

			//for(int i = 0; i < i_arr_2.GetLength(0); i++)
			//{
			//	for(int j = 0; j < i_arr_2.GetLength(0); j++)
			//	{
			//		i_arr_2[i,j] = rand.Next(100);
			//	}
			//}
			//Console.WriteLine();
			
			for (int i = 0; i < i_arr_2.GetLength(0); i++)
			{
				for (int j = 0; j < i_arr_2.GetLength(1); j++)
				{
					Console.Write(i_arr_2[i, j] + "\t");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			//int sum = 0;
			//for(int i = 0; i < i_arr_2.GetLength(0); i++)
			//{
			//	for(int j = 0; j < i_arr_2.GetLength(1); j++)
			//	{
			//		sum += i_arr_2[i,j];
			//	}
			//}
			//Console.WriteLine($"Сумма элементов массива: {sum}");	
			Console.WriteLine($"Сумма элементов массива: {i_arr_2.Cast<int>().Sum()}");	
			Console.WriteLine($"Средне-арифмитическое элементов массива: {i_arr_2.Cast<int>().Average()}");	
			Console.WriteLine($"Максимальное значение в массиве: {i_arr_2.Cast<int>().Max()}");	
			Console.WriteLine($"Минимальное значение в массиве: {i_arr_2.Cast<int>().Min()}");	
			*/
			#endregion ARRAY_2

			#region RAGGED_ARRAY
			/*
			//Console.Write("Введите количество строк: ");
			//int rows = Convert.ToInt32(Console.ReadLine());
			//Console.Write("Введите количество элементов строки: ");
			//int cols = Convert.ToInt32(Console.ReadLine());

			int[][] ragged_arr = new int[5][];      //объявляем массив указателей (ссылок)


			ragged_arr[0] = new int[] { 0, 1, 1, 2};
			ragged_arr[1] = new int[] { 3, 5, 8 };
			ragged_arr[2] = new int[] { 13, 21, 34, 55, 89 };
			ragged_arr[4] = new int[] { 144, 233, 377 };
			//for(int i = 0; i < ragged_arr.Length; i++)
			//{
			//	ragged_arr[i] = new int[cols];
			//}

			Random rand = new Random(0);
			//for(int i = 0; i < ragged_arr.Length; i++)
			//{
			//	for(int j = 0; j < ragged_arr[i].Length; j++)
			//	{
			//		ragged_arr[i][j] = rand.Next(100);
			//	}
			//	
			//}


			//for(int i = 0; i < ragged_arr.Length; i++)
			//{
			//	for(int j = 0; j < ragged_arr[i].Length; j++)
			//	{
			//		Console.Write(ragged_arr[i][j] + "\t");
			//	}
			//	Console.WriteLine();
			//}
			foreach( int[] i in ragged_arr)      //Итератор 'i' перебирает массивы
			{
				if (i != null)
				{
					foreach (int j in i)             //Итератор 'j' перебирает элементы массива
					{
						Console.Write(j + "\t");
					}
				    Console.WriteLine();
				}
				else
				{
					Console.WriteLine("Строка пустая");
				}
				
			}

			int sum = 0;
			int count = 0;
			foreach(int[] i in ragged_arr)
			{
			   if (i != null)
			   {
			     sum += i.Sum();
			     count += i.Length;
			   }
			}
			Console.WriteLine($"Сумма элементов массива: {sum}");
			Console.WriteLine($"Средне-арифметическое элементов массива: {(double)sum / count}");
			Console.WriteLine($"Минимальное значение в массиве: {min}");
			Console.WriteLine($"Максимальное значение в массиве: {max}");
			*/
			#endregion RAGGED_ARRAY

			#region ENUMS

			Season season = Season.Spring;
			Console.WriteLine(season);

			foreach (Week i in System.Enum.GetValues(typeof(Week)).Cast<Week>())
			{
				Console.WriteLine(i);
			}

			string[] dayName = Enum.GetNames(typeof(Week));
			int[] dayNumbers = (int[])Enum.GetValues(typeof(Week));
			for(int i = 0; i < dayNumbers.Length; i++)
			{
				Console.WriteLine($"Name: {dayName[i]} \t- Value: {dayNumbers[i]}");
			}
			Console.WriteLine(delimiter);

			string[] distName  = Enum.GetNames(typeof(DistanceFromSun));
			ulong[] distValue = (ulong[])Enum.GetValues(typeof(DistanceFromSun));
			
			// получаем имена и значения:
			for(int i =0; i < distName.Length; i++)
			{
				Console.WriteLine($"Name: {distName[i]} \t- Value: {distValue[i]}");
			}

			Console.WriteLine($"Type: {Enum.GetUnderlyingType(typeof(DistanceFromSun))}");
			
		}
		const string delimiter = "\n--------------------------------------------------------------------\n";

		enum Season
		{
			Winter, Spring, Summer, Autumn
		};
		enum Week:uint
		{
			Sunday = 0,
			Monday = 1,
			Tuesday = 2,
			Wednesday = 3,
			Thursday = 4,
			Friday = 5,
			Saturday = 6,
			
		};

		enum DistanceFromSun : ulong
		{
			Sun = 0,
			Mercury = 57900000,
			Venus = 108200000,
			Earth = 149600000,
			Mars = 227900000,
			Jupiter = 7783000000,
			Saturn = 1427000000,
			Uranus = 2870000000,
			Neptune = 4496000000,
			Pluto = 594600000
		}
	}
}
