using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLib
{
    /// <summary>
    /// The class Fraction, meant to represent a fraction as in math.
    /// </summary>
    public partial class Fraction
    {
        private int _numerator;
        private int _denominator;

        /// <summary>
        /// The numerator of the fraction
        /// </summary>
        public int Numerator {
            get { return _numerator; }
            set { _numerator = value; } }

        /// <summary>
        /// The denominator of the fraction
        /// </summary>
        public int Denominator {
            get { return _denominator; }
            set { _denominator = value; } }

        /// <summary>
        /// The default no parameter constructor
        /// </summary>
        public Fraction()
        {
            _numerator = 0;
            _denominator = 1;
        }

        /// <summary>
        /// The two parameter constructor with numerator and denominator
        /// </summary>
        /// <param name="num">The numerator</param>
        /// <param name="den">The denominator</param>
        public Fraction(int num, int den)
        {
            _numerator = num;
            _denominator = den;
        }
    }
}
