using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCodeDayOne
{
    class Program
    {
        static void Main(string[] args)
            {
                List<string> values = File.ReadLines("Values.txt").ToList();
                int finalValue = 0;
                finalValue = values.Sum(x => int.Parse(x) + finalValue);
        }
    }
}
