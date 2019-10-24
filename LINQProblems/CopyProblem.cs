using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class CopyProblem
    {
        List<string> names;
        public CopyProblem()
        {
            names = new List<String>() { "Mike", "Brad", "Nevin", "Mike"};
            var instructors = names.Distinct();
            foreach(var value in instructors)
            {
                Console.WriteLine(value);
            }
        }
    }
}
