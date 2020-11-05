using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace AnagramConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var word1 = "odd";
            var word2 = "noddles";

            var result = Anagram(word1, word2);

            Console.WriteLine(result);
        }

        static bool Anagram(string word1, string word2)
        {
            int cont = 0;

            var lettersWord1 = word1.ToCharArray().ToList();


            foreach (var letter in word2)
            {
                if (lettersWord1.Contains(letter))
                {
                    lettersWord1.Remove(letter);
                    cont++;
                }
                else
                {
                    cont = 0;
                }

                if (cont==word1.Length)
                {
                    return true;
                }
                
            }

            return false;
        }
    }
}
