using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_11
{
    public delegate int Operation(int a, int b);
    public class Calculator
    {
        public int Calculate(int a, int b, Operation operation)
        {
            return operation(a, b);
        }
        //
    }
}
