using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine(array[4]);

            array[4] = 10;

            Console.WriteLine(array[4]);

            Console.ReadKey();
        }
    }
}
