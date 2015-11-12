using System;
using OurLib;

namespace ConsoleApplication1
{
    class ConsoleTest
    {
        static void Main(string[] args)
        {
            Tuple<double, double> a = new Tuple<double, double>(0.0, 0.0);
            Tuple<double, double> b = new Tuple<double, double>(5.0, 5.0);
            Tuple<double, double> c = new Tuple<double, double>(0.0, 0.0);
            Tuple<double, double> d = new Tuple<double, double>(5.0, 0.0);
            Console.WriteLine(TwoLines.IsIntersect(a, b, c, d) ? "DA" : "NET");        
        }
    }
}
