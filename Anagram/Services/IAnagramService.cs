using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Anagram.Services
{
    public interface IAnagramService
    {
        bool PostAnagram(string word1, string word2);
    }
}
