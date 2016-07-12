using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace MathMorePoly
{
    /// <summary>
    /// Make sure we got the math more polynomial class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // 1.0*x + 5.0
            var p = new ROOTNET.NROOT.NMath.NPolynomial(1.0, 5.0);
            double value = 0.0, derivative = 0.0;
            p.FdF(2.0, ref value, ref derivative);

            WriteLine($"Value = {value} (should be 7), derivative is {derivative} (should be 1).");

        }
    }
}
