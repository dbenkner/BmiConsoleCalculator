using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiConsoleCalculator
{
    internal class Person
    {
        public double height { get; set; }
        public double weight { get; set; }

        public Person(double height, double weight)
        {
            this.height = height;
            this.weight = weight;
        }
        public double getBMI(double height, double weight, bool isEng)
        {

            return (isEng == true) ? Math.Round((weight / Math.Pow(height, 2) * 703), 5) : Math.Round(weight / Math.Pow((height / 100), 2), 5);
        }
    }


}
