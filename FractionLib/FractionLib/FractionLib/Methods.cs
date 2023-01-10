using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLib
{
    public partial class Fraction
    {
        private int GCD()
        {
            int a = _numerator;
            int b = _denominator;

            while (a != b) {
                if (a > b) a -= b;
                else       b -= a; }

            return a;
        }

        /// <summary>
        /// Divides the numerator and denominator with their GCD to
        /// get smaller version of the fraction.
        /// </summary>
        public void Normalize()
        {
            int gcd = GCD();

            _numerator /= gcd;
            _denominator /= gcd;
        }

        /// <summary>
        /// Gives the equivalent decimal value of the fraction.
        /// </summary>
        /// <returns>The equivalent decimal value</returns>
        public double Value()
        {
            return ((double)_numerator) / _denominator;
        }

        /// <summary>
        /// Method to honor the creator of this library.
        /// </summary>
        /// <returns>The About string</returns>
        public static string About()
        {
            return "Fraction library, created by Muhazam Mustapha\n" +
                   "January 2023\n" +
                   "Go to GitHub: \n" +
                   "for more information.";
        }

        /// <summary>
        /// Gives the string equivalent of the fraction for printing purposes.
        /// </summary>
        /// <returns>The string equivalent of the fraction</returns>
        public override string ToString()
        {
            return _numerator.ToString()+"/"+_denominator.ToString();
        }
    }
}
