using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiConsoleCalculator
{
    internal class Person
    {
        public int height { get; set; }
        public int weight { get; set; }

        public Person(int height, int weight)
        {
            this.height = height;
            this.weight = weight;
        }
        public double getBMI(int height, int weight)
        {
            return Math.Round((weight / Math.Pow(height, 2) * 703), 5);
        }
    }


}
