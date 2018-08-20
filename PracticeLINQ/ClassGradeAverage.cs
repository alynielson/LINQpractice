using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeLINQ
{
    class ClassGradeAverage
    {

        public double GetClassAverage(List<string> stringsOfGrades)
        {
            var classAverage = stringsOfGrades.Select(stringGrades => Array.ConvertAll<string, double>(stringGrades.Split(','), Convert.ToDouble).OrderBy(grade => grade).Skip(1).Average()).Average();
            return classAverage;
        } 
    }
}
