using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan angka: ");
            string input = Console.ReadLine();

            // Melakukan iterasi dari digit pertama hingga terakhir
            for (int i = 0; i < input.Length; i++)
            {
                // Menghitung nilai tempat sesuai dengan digit
                int placeValue = (int)Math.Pow(10, input.Length - i - 1);
                // Mengkonversi digit ke dalam angka dan mengalikannya dengan tempat nilainya
                int value = (input[i] - '0') * placeValue;
                // Menampilkan hasil
                Console.WriteLine(value);
            }
        }
    }
}
