using System;

namespace OurLib
{
    public class TwoLines
    {
        public static bool IsIntersect(Tuple<double, double> a, Tuple<double, double> b, Tuple<double, double> c, Tuple<double, double> d)
        {
            double v1, v2, v3, v4;
            if ((a.Item1 == c.Item1 && a.Item2 == c.Item2) || (b.Item1 == d.Item1 && b.Item2 == d.Item2) ||
                (a.Item1 == d.Item1 && a.Item2 == d.Item2) || (b.Item1 == c.Item1 && b.Item2 == c.Item2)) return true;
            v1 = (d.Item1 - c.Item1) * (a.Item2 - c.Item2) - (d.Item2 - c.Item2) * (a.Item1 - c.Item1);
            v2 = (d.Item1 - c.Item1) * (b.Item2 - c.Item2) - (d.Item2 - c.Item2) * (b.Item1 - c.Item1);
            v3 = (b.Item1 - a.Item1) * (c.Item2 - a.Item2) - (b.Item2 - a.Item2) * (c.Item1 - a.Item1);
            v4 = (b.Item1 - a.Item1) * (d.Item2 - a.Item2) - (b.Item2 - a.Item2) * (d.Item1 - a.Item1);
            bool res = v1 * v2 < 0 && v3 * v4 < 0;
            return res;
        }
    }
}
