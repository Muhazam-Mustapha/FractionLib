using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionLib
{
    public partial class Fraction
    {
        /// <summary>
        /// Addition of two fractions
        /// </summary>
        /// <param name="op1">Operand 1</param>
        /// <param name="op2">Operand 2</param>
        /// <returns>The added fraction</returns>
        public static Fraction operator+(Fraction op1, Fraction op2)
        {
            Fraction tempFrac = new Fraction();

            tempFrac.Numerator = op1.Numerator*op2.Denominator +
                                 op2.Numerator*op1.Denominator;

            tempFrac.Denominator = op1.Denominator*op2.Denominator;

            return tempFrac;
        }

        public static Fraction operator-(Fraction op1, Fraction op2)
        {
            Fraction tempFrac = new Fraction();

            tempFrac.Numerator = op1.Numerator * op2.Denominator -
                                 op2.Numerator * op1.Denominator;

            tempFrac.Denominator = op1.Denominator * op2.Denominator;

            return tempFrac;
        }

        public static Fraction operator*(Fraction op1, Fraction op2)
        {
            Fraction tempFrac = new Fraction();

            tempFrac.Numerator = op1.Numerator * op2.Numerator;

            tempFrac.Denominator = op1.Denominator * op2.Denominator;

            return tempFrac;
        }

        public static Fraction operator/(Fraction op1, Fraction op2)
        {
            Fraction tempFrac = new Fraction();

            tempFrac.Numerator = op1.Numerator * op2.Denominator;

            tempFrac.Denominator = op1.Denominator * op2.Numerator;

            return tempFrac;
        }
    }
}
