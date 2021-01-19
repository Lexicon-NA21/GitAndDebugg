using System;
using System.Collections.Generic;
using System.Linq;

namespace GitAndDebugg
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int x = 4;
            int y = 6;

            int result = GetSum(x, y);

            int[] list = Enumerable.Range(1, 10000).ToArray();

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(i);
            }

            List<Car> cars = new List<Car>();

            cars.Add(new Car("Vovlo", 1984));


            

            Console.WriteLine("Hej");

            x = 8;
        }

        private static int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
