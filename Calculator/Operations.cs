using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operations
{
    /// <summary>
    /// Two digits class
    /// </summary>
    public class Digits
    {
        // Variable for first digit.
        private double _a = 0; 
        // Variable for second digit.
        private double _b = 0; 

        /// <summary>
        /// Property for first digit.
        /// </summary>
        public double ValueOfA
        { get { return _a; } set { _a = value; } }

        /// <summary>
        /// Property for second digit.
        /// </summary>
        public double ValueOfB
        { get { return _b; } set { _b = value; } }

        /// <summary>
        /// Method that clears value of digits.
        /// </summary>
        public void Clear()
        {
            _a = 0;
            _b = 0;
        }
    }

    /// <summary>
    /// Math operation class.
    /// </summary>
    public static class MathOperations
    {
        //Exception for cases where a user tries to divide by zero.
        private static Exception DividedByZeroException = new Exception("Can`t divide by zero");
        //Exception for cases where a user tries to calculate root of negative value.
        private static Exception NegativeRootException = new Exception("Can`t calculate root");


        /// <summary>
        /// Calculates the sum of first and second digits.
        /// </summary>
        /// <param name="a">First digit.</param>
        /// <param name="b">Second digit.</param>
        /// <returns>Sum of digits.</returns>
        public static double Add(Double a, Double b)
        {
            return a + b;
        }

        /// <summary>
        /// Calculates the difference of first and second digits.
        /// </summary>
        /// <param name="a">First digit.</param>
        /// <param name="b">Second digit.</param>
        /// <returns>Difference of digits.</returns>
        public static double Substract(Double a, Double b)
        {
            return a - b;
        }

        /// <summary>
        /// Calculates the product of first and second digits.
        /// </summary>
        /// <param name="a">First digit.</param>
        /// <param name="b">Second digit.</param>
        /// <returns>Product of digits.</returns>
        public static double Multiply(Double a, Double b)
        {
            return a * b;
        }

        /// <summary>
        /// Calculates the quotient of first and second digits.
        /// </summary>
        /// <param name="a">First digit.</param>
        /// <param name="b">Second digit.</param>
        /// <returns>Quotient of digits.</returns>
        public static double Divide(Double a, Double b)
        {
            if (Math.Abs(b) < 0.00000001) throw DividedByZeroException;
            else return a / b;
        }

        /// <summary>
        /// Calculates the square root of digit.
        /// </summary>
        /// <param name="a">Digit for calculation.</param>
        /// <returns>Square root of digit.</returns>
        public static double SquareRoot(Double a)
        {
            if (a < 0) throw NegativeRootException;
            else return Math.Sqrt(a);
        }

        /// <summary>
        /// Calculates the cosine of angle in radians.
        /// </summary>
        /// <param name="a">Angle in degrees</param>
        /// <returns>Cosine of 'a' degrees in radians</returns>
        public static double Cos(Double a)
        {
            return Math.Cos(a * Math.PI / 180);
        }

        /// <summary>
        /// Calculates 1 / 'a'
        /// </summary>
        /// <param name="a">Divisor</param>
        /// <returns>1 / 'a'</returns>
        public static double OneDividedBy(Double a)
        {
            if (Math.Abs(a) < 0.00000001) throw DividedByZeroException;
            else return 1 / a;
        }
    }
}
