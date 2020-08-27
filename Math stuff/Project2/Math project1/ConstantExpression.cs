using System;
using System.Collections.Generic;
using System.Text;

namespace Math_project1
{
    class ConstantExpression : Expression
    {
        private int value;

        public ConstantExpression(int newValue)
        {
            value = newValue;
        }

        public override int evaluate(int x)
        {
            return value;
        }

        public override void printMe(int depth)
        {
            Console.WriteLine("-- " + value);
        }
    }
}
