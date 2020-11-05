using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Services
{
    public class AnagramService : IAnagramService
    {
        public bool PostAnagram(string word1, string word2)
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

                if (cont == word1.Length)
                {
                    return true;
                }

            }

            return false;
        }
    }
}
