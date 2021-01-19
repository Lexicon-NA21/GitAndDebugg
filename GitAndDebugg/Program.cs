using System;
using System.Linq;

namespace GitAndDebugg
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;

            int result = GetSum(x, y);

            int[] list = Enumerable.Range(1, 10000).ToArray();

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Hej");
        }

        private static int GetSum(int x, int y)
        {
            return x + y;
        }
    }
}
