using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


/*
 * NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };
 */

namespace CSharp_for_education
{
    class homework
    {

        public static void Ariphmetics()
        {
            Console.Write("Введите 1-ое число: ");
            double first = double.Parse(Console.ReadLine());

            Console.Write("Введите 2-ое число: ");
            double second = double.Parse(Console.ReadLine());

            double res = (first + second) / 2.0;

            Console.WriteLine("Среднее арифметическое чисел: " + first + " и " + second + " = " + res);


        }

        public static void Sumandproiz()
        {
            Console.Write("Введите 1-ое число: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите 2-ое число: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Введите 3-ое число: ");
            double c = double.Parse(Console.ReadLine());

            double sum = a + b + c;
            double proiz = a * b * c;

            Console.WriteLine("Сумма: " + sum + '\n' + "Произведение: " + proiz);

        }

        public static void Konverter()
        {
            Console.Write("Введите число долларов: ");
            double a = double.Parse(Console.ReadLine());

            double dollar = 73.78, res;
            res = dollar * a;
            Console.WriteLine("Столько в рублях будет " + a + " долларов: " + res);

        }

        public static void Chetnoctb()
        {
            Console.Write("Введите число: ");
            int value = int.Parse(Console.ReadLine());

            if (value % 2 == 0) { Console.WriteLine("Число чётное"); }

            else if (value == 0) { Console.WriteLine("Вы ввели 0"); }

            else { Console.WriteLine("Число нечётное"); }
                
        }

        public static void Calculator()
        {
            bool isExit = false;
            while (!isExit)
            {
                Console.WriteLine("Введите номер функции, которая сделает калькулятор");
                Console.WriteLine("1. if, else\n2. switch, case");
                int choiceFunc = int.Parse(Console.ReadLine());

                if (choiceFunc == 1)
                {

                    Console.Write("Введите 1-ое число: ");
                    double firstValue = double.Parse(Console.ReadLine());

                    Console.Write("Введите 2-ое число: ");
                    double secondValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите номер операции");
                    Console.WriteLine("1. - \n2. + \n3. * \n4. / \n5. % ");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1) { Console.WriteLine("\t" + firstValue + " - " + secondValue + " = " + (firstValue - secondValue)); }
                    else if (choice == 2) { Console.WriteLine("\t" + firstValue + " + " + secondValue + " = " + (firstValue + secondValue)); }
                    else if (choice == 3) { Console.WriteLine("\t" + firstValue + " * " + secondValue + " = " + (firstValue * secondValue)); }
                    else if (choice == 4)
                    {
                        Console.WriteLine("\t" + firstValue + " / " + secondValue + " = " + (firstValue / secondValue));
                        if (secondValue == 0) { Console.WriteLine("На ноль делить нельзя!"); }
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("\t" + firstValue + " % " + secondValue + " = " + (firstValue % secondValue));
                        if (secondValue == 0) { Console.WriteLine("На ноль делить нельзя!"); }
                    }
                }

                else if (choiceFunc == 2)
                {
                    Console.Write("Введите 1-ое число: ");
                    double firstValue = double.Parse(Console.ReadLine());

                    Console.Write("Введите 2-ое число: ");
                    double secondValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите номер операции");
                    Console.WriteLine("1. - \n2. + \n3. * \n4. / \n5. % ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine(firstValue + " - " + secondValue + " = " + (firstValue - secondValue));
                            break;
                        case 2:
                            Console.WriteLine("\t" + firstValue + " + " + secondValue + " = " + (firstValue + secondValue));
                            break;
                        case 3:
                            Console.WriteLine("\t" + firstValue + " * " + secondValue + " = " + (firstValue * secondValue));
                            break;
                        case 4:
                            Console.WriteLine("\t" + firstValue + " / " + secondValue + " = " + (firstValue / secondValue));
                            if (secondValue == 0) { Console.WriteLine("На ноль делить нельзя!"); }
                            break;
                        case 5:
                            Console.WriteLine("\t" + firstValue + " % " + secondValue + " = " + (firstValue % secondValue));
                            if (secondValue == 0) { Console.WriteLine("На ноль делить нельзя!"); }
                            break;

                        default:
                            Console.WriteLine("Вы ввели неверное число...");
                            break;
                    }
                }

                else { Console.WriteLine("Вы неверное число..."); }

                Console.WriteLine("Хотите закрыть калькулятор?\n1. Да\n2. Нет");
                int exit = int.Parse(Console.ReadLine());

                if(exit == 1) { isExit = true; }
                else if(exit == 2) { isExit = false; }
                else { Console.WriteLine("Вы ввели неверное число..."); }
                Console.Clear();
            }
        }

        public static void Triangle()
        {
            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = height; i > 0; i--)
            {
                for(int j = 0; j < i; ++j)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            Console.WriteLine('\n');
        }

        public static void PasswordCheck()
        {
            bool Check;

            string TruePassword = "unicode";

            Console.Write("Введите пароль: ");
            string EnteredPassword = Console.ReadLine();

            Check = TruePassword == EnteredPassword ? true : false;
            Console.WriteLine(Check);
        }

        public static void ModuleCheck()
        {

            Console.Write("Введите число: ");

            int inputValue = int.Parse(Console.ReadLine());
            int outputValue = inputValue > 0 ? inputValue : 0;

            Console.WriteLine(outputValue);

        }

        public static void ArrayWork() {

            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("array[" + i +"]" + " = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Clear();

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(arr[i] + " ");
            }

            int sum = 0;
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] %2 == 0)
                    sum += arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Сумма чётных чисел: " + sum + "\nМинимальное число в массиве: " + min);
            


        }

        //static void Main(string[] args)
        //{


        //    ArrayWork();

        //    Console.WriteLine("Press any key to close...");
        //    Console.ReadKey();
        //}

    }
}
