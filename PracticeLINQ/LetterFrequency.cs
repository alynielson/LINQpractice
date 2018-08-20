using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class LetterFrequency
    {
        public string CountNumberOfEachLetter(string word)
        {
            var newWord = string.Join("",(word.ToUpper().Select(l => $"{l}{word.ToUpper().Count(y => y == l)}").Distinct().OrderBy(l => l))) ;
            return newWord;

            
        }
    }
}
