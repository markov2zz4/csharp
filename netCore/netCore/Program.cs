using System;

namespace netCore
{
    class Program
    {
        static void IndexAndDiapason()
        {
            int[] array = { 8, 7, 5, 3, 2 };

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }


            //----------------------------Работа с индексом--begin----------------------------//
            Console.WriteLine("\n\nКонец массива: " + array[^1]); // Получаем последнее значение в списке, нумерация с единицы.

            int[] newArray = array[..4]; // Извлечение эл-ов в массиве с ([..4] = 0 -> 4) / ([4..] = 4 -> Конец)

            Index myIndexEnd = ^2, myIndexHome = 2; // тип_данных имя_переменной = ^значение

            Console.WriteLine("\nЭлемент с конца ^2 (-1): " + array[myIndexEnd]);
            Console.WriteLine($"value = {myIndexEnd.Value} isFromEnd {myIndexEnd.IsFromEnd}"); // value _ bool(с конца ли?)

            Console.WriteLine("\nЭлемент с начала 2: " + array[myIndexHome]);
            Console.WriteLine($"value = {myIndexHome.Value} isFromEnd {myIndexHome.IsFromEnd}"); // value _ bool(с конца ли?)
            //----------------------------Работа с индексом--end----------------------------//

            //----------------------------Работа с диапазоном--begin----------------------------//

            Range myRange = 1..4; // Содержит два Index'a / Range(1,4) == Range(1..4)

            newArray = array[myRange];
            Console.WriteLine($"\nNew Array with range: {myRange}");

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] + " ");
            }

            string str = "HelloWorld<3";
            Console.WriteLine("\n\n" + str[5..^2]); // 7 не берётся



            //----------------------------Работа с диапазоном--end----------------------------//

        }

        static void TwodimensionalArray()
        {

            
            Random rand = new Random();
            

            int[,] DimensionalArray = new int[3,3];

            for (int i = 0; i < DimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < DimensionalArray.GetLength(1); j++)
                {
                    Console.Write($"Введите число {j} индекса: ");
                    DimensionalArray[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();

            }

            for (int i = 0; i < DimensionalArray.GetLength(0); i++)
            {
                for (int j = 0; j < DimensionalArray.GetLength(1); j++)
                {
                    Console.Write(DimensionalArray[i, j] + " ");
                }
                Console.WriteLine();
                
            }
        }

        static void ToothedArray()
        {

            Random rand = new Random();

            int[][] meArray = new int[4][];

            for (int i = 0; i < meArray.Length; i++)
            {
                meArray[i] = new int [rand.Next(1, 7)];
            }

            for (int i = 0; i < meArray.Length; i++)
            {
                for (int j = 0; j < meArray[i].Length; j++)
                {
                    meArray[i][j] = rand.Next(0, 10);
                }
            }
            
            for (int i = 0; i < meArray.Length; i++)
            {
                for (int j = 0; j < meArray[i].Length; j++)
                {
                    Console.Write(meArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void MultiDimensionalArray()
        {
            int[,,] myArray = new int[4, 3, 5];
            

            Random random = new Random();

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        myArray[i, j, k] = random.Next(0, 20);
                    }
                }
            }

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                Console.WriteLine($"Page № {i+1}:");
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    for (int k = 0; k < myArray.GetLength(2); k++)
                    {
                        Console.Write(myArray[i, j, k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
        }

        static void ToothedMultiDimensionalArray()
        {
            Random random = new Random();

            int[][][] myArray = new int[random.Next(3, 6)][][];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = new int[random.Next(2, 4)][];
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = new int[random.Next(3, 5)];

                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        myArray[i][j][k] = random.Next(0, 100);
                    }
                    
                }
                
            }

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine($"Page № {i + 1}:");
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    for (int k = 0; k < myArray[i][j].Length; k++)
                    {
                        Console.Write(myArray[i][j][k] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        static int ArrayOf(int[] array, int value)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                    return i;
            }
            return -1;
        }

        

        static void Main(string[] args)
        {

            int chusl = 799;
            double znam = 878;
            double res = 799 % 878;

            Console.WriteLine(res);



            Console.ReadKey();
        }
    }
}
