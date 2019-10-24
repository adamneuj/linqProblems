using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class THProblem
    {
        List<string> words;
        public THProblem()
        {
            words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var word = words.Where(w => w.Contains("th"));
            foreach(var w in word)
            {
                Console.WriteLine(w);
            }
        }
    }
}
