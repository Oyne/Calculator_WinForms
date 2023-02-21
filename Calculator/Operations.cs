using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    class Digits
    {
        private double _a = 0; //Variable for first digit
        private double _b = 0; //Variable for second digit

        /// <summary>
        /// Property for first digit
        /// </summary>
        public double ValueOfA
        { get { return _a; } set { _a = value; } }

        /// <summary>
        /// Property for second digit
        /// </summary>
        public double ValueOfB
        { get { return _b; } set { _b = value; } }

        /// <summary>
        /// Method that clears value of digits
        /// </summary>
        public void Clear()
        {
            _a = 0;
            _b = 0;
        }
    }

    static class MathOperations
    {
        private static Exception DividedByZeroException = new Exception("Can`t divide by zero"); //Exception for cases where a user tries to divide by zero
        private static Exception NegativeRootException = new Exception("Can`t calculate root"); //Exception for cases where a user tries to calculate root of negative value

        /// <summary>
        /// Method that calculates the sum of first and second digits
        /// </summary>
        /// <param name="digits">Digits for calculation</param>
        /// <returns>Sum of digits</returns>
        public static double Add(Digits digits)
        {
            return digits.ValueOfA + digits.ValueOfB;
        }

        /// <summary>
        /// Method that calculates the difference of first and second digits
        /// </summary>
        /// <param name="digits">Digits for calculation</param>
        /// <returns>Difference of digits</returns>
        public static double Substract(Digits digits)
        {
            return digits.ValueOfA- digits.ValueOfB;
        }

        public static double Multiply(Digits digits)
        {
            return digits.ValueOfA * digits.ValueOfB;
        }

        public static double Divide(Digits digits)
        {
            if (Math.Abs(digits.ValueOfB) < 0.01) throw DividedByZeroException;
            else return digits.ValueOfA / digits.ValueOfB;
        }

        public static double SquareRoot(Digits digits)
        {
            if (digits.ValueOfA < 0) throw NegativeRootException;
            else return Math.Sqrt(digits.ValueOfA);
        }

        public static double Cos(Digits digits)
        {
            return Math.Cos(digits.ValueOfA * Math.PI / 180);
        }

        public static double OneDividedBy(Digits digits)
        {
            if (Math.Abs(digits.ValueOfA) < 0.01) throw DividedByZeroException;
            else return 1 / digits.ValueOfA;
        }
    }
}
