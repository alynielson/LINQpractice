using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class SubstringTH 
    {
        public IEnumerable<string> FindWordsWithTH(List<string> allWords)
        {
            var newList = allWords.Where(word => word.Contains("th"));
            return newList;
        }
    }
}
