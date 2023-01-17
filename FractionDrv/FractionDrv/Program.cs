using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionLib;

namespace FractionDrv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(2, 5);
            Fraction f2 = new Fraction(3, 4);

            Fraction f3 = f1 - f2;

            f3.Normalize();
        }
    }
}
