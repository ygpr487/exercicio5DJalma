using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio5DJalma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            Console.WriteLine("números pares entre 1 e 100\n");

            for (n = 2; n < 100; n=n+2)
            {
                Console.WriteLine(n);
                
            }

            Console.ReadKey();
        }
    }
}
