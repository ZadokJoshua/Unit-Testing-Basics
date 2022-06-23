using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class MathClass
    {
        public double Addition(int n1, int n2)
        {
            return n1 + n2;
        }

        public double Subtract(int n1, int n2)
        {
            return (n1 - n2);
        }

        public double Multiply(int n1, int n2)
        {
            return (n1 * n2);
        }

        public double Divide(int n1, int n2)
        {
            return (n1 / n2);
        }
    }
}
