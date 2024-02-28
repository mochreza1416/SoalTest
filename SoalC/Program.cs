using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan string: ");
            string input = Console.ReadLine();

            Dictionary<char, int> characterCount = CountCharacters(input);

            // Menampilkan output
            foreach (KeyValuePair<char, int> kvp in characterCount)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
        static Dictionary<char, int> CountCharacters(string input)
        {
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char lowercaseChar = char.ToLower(c);
                    if (characterCount.ContainsKey(lowercaseChar))
                    {
                        characterCount[lowercaseChar]++;
                    }
                    else
                    {
                        characterCount[lowercaseChar] = 1;
                    }
                }
            }

            return characterCount;
        }
    }
}
