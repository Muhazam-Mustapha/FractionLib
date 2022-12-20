# FractionLib
The DLL version of the GUI based Fraction project at:

[https://github.com/Muhazam-Mustapha/Fraction](https://github.com/Muhazam-Mustapha/Fraction)

Sample usage:

<code>
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionLib;

namespace FractionLibDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction aFrac = new Fraction();

            aFrac.Numerator = 5;
            aFrac.Denominator = 10;

            Console.WriteLine(Fraction.About());

            Console.WriteLine("aFrac = {0}/{1}", aFrac.Numerator, aFrac.Denominator);

            Console.WriteLine(aFrac.Value());

            Fraction Frac2 = new Fraction(42, 210);
            Console.WriteLine("Frac2 = {0}/{1}", Frac2.Numerator, Frac2.Denominator);
            Frac2.Normalize();
            Console.WriteLine("Frac2 = {0}/{1}", Frac2.Numerator, Frac2.Denominator);

            Console.WriteLine("Print with ToString: " + Frac2.ToString());

            Console.ReadKey();
        }
    }
}
</code>
