using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problem 1
            IEnumerable<string> wordsWithTH = new SubstringTH().FindWordsWithTH(new List<string> { "the", "bike", "this", "it", "tenth", "mathematics" });
            Console.WriteLine("Problem 1.");
            foreach (string word in wordsWithTH)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //Problem 2

            

        }
    }
}
