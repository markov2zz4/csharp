using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class laboratory
    {
        public static void GeometryConsole()
        {
            Console.Write("Введите высоту треугольника: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }


            Console.WriteLine('\n');
        }

        static void Main(string[] args)
        {
            GeometryConsole();
        }
    }
}