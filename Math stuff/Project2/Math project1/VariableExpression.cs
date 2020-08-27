using System;
using System.Collections.Generic;
using System.Text;

namespace Math_project1
{
    class VariableExpression : Expression
    {
        public override int evaluate(int x)
        {
            return x;
        }

        public override void printMe(int depth)
        {
            Console.WriteLine("-- x");
        }
    }
}
