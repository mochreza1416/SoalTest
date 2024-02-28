using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan nilai N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i != 5)
                {
                    Console.Write("IDIC ");
                }
                else if (i % 6 == 0 && i != 6)
                {
                    Console.Write("LPS ");
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
