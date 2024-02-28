using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string input = Console.ReadLine();

            string judulFormat = FormatJudul(input);
            string biasaFormat = FormatBiasa(input);

            Console.WriteLine("Output:");
            Console.WriteLine($"Format Judul: {judulFormat}");
            Console.WriteLine($"Format Biasa: {biasaFormat}");
        }
        static string FormatJudul(string input)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }

        static string FormatBiasa(string input)
        {
            return input.First().ToString().ToUpper() + input.ToLower().Substring(1);
        }
    }
}
