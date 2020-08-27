using System;
using System.Collections.Generic;
using System.Text;

namespace Math_project1
{
    class MultiplyExpression : Expression
    {
        public MultiplyExpression(Expression newLeft, Expression newRight)
        {
            left = newLeft;
            right = newRight;
        }
        private Expression left;
        private Expression right;
        public override int evaluate(int x)
        {
            return left.evaluate(x) * right.evaluate(x);
        }

        public override void printMe(int depth)
        {
            Console.WriteLine("-- *");
            left.print(depth + 1);
            right.print(depth + 1);
        }
    }
}
