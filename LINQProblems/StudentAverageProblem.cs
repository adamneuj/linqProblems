using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProblems
{
    class StudentAverageProblem
    {


        public StudentAverageProblem()
        {
            List<string> classGrades = new List<string>()
            {
            "80,100,92,89,65",
            "93,81,78,84,69",
            "73,88,83,99,64",
            "98,100,66,74,55"
            };
            StudentAverage(classGrades);
        }

        public double StudentAverage(List<string> grades)
        {
            var Temp = new List<double>();
            foreach (string item in grades)
            {
                var SplitGrades = item.Split(',').Select(int.Parse).ToList();
                var LowestGradeRemoved = SplitGrades.Where(g => g != SplitGrades.Min());
                double result = LowestGradeRemoved.Average();
                Temp.Add(result);
            }

            double finalaverage = Temp.Average();
            return finalaverage;
        }
    }
}
