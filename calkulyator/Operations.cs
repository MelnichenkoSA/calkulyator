using System;
using System.Collections.Generic;
using System.Text;

namespace calkulyator
{
    class Operations
    {
        public double Calculate(string expression)
        {
            double result = 0;
            string[] ops = expression.Split('+', '-', '*', '/');
            double firstp = double.Parse(ops[0]);
            double secondp = double.Parse(ops[1]);
            char op = expression[ops[0].Length];

            switch (op)
            {
                case '+': result = firstp + secondp; break;
                case '-': result = firstp - secondp; break;
                case '*': result = firstp * secondp; break;
                case '/': result = firstp / secondp; break;
            }

            return result;
        }
    }
}
