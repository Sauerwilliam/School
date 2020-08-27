using System;
using System.Collections.Generic;
using System.Text;

namespace Math_project1
{
    public abstract class Expression
    {
        public void print(int depth)
        {

            for(int i = 0; i < depth; i++)
            {
                Console.Write("|   ");
                printMe(depth);
            }
        }

        public abstract void printMe(int depth);

        public abstract int evaluate(int x);
    }
}
