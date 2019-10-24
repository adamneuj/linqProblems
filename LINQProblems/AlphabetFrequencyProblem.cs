using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class AlphabetFrequencyProblem
    {
        public AlphabetFrequencyProblem()
        {
            AlphabeticalFrequency();
        }
        public void AlphabeticalFrequency()
        {
            string[] name = { "T", "e", "r", "r", "i", "l", "l" };
            var frequency = from f in "terrill"
                            group f by f into letterfrequency
                            orderby letterfrequency.Key
                            select new
                            {
                                Letter = letterfrequency.Key,
                                Frequency = letterfrequency.Count()
                            };

            foreach (var f in frequency)
            {
                Console.WriteLine($"{f.Letter}{f.Frequency}");
            }
        }
    }
}
