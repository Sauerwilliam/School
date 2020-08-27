using System;
using System.Collections.Generic;
using System.Text;

namespace Math_project1
{
    class DivideExpression : Expression
    {
        private Expression left;
        private Expression right;
        public DivideExpression(Expression newLeft, Expression newRight)
        {
            left = newLeft;
            right = newRight;
        }
            
        public override int evaluate(int x)
        {
            return left.evaluate(x) / right.evaluate(x);
        }

        public override void printMe(int depth)
        {
            Console.WriteLine("-- /");
            left.print(depth + 1);
            right.print(depth + 1);
        }
    }
}
