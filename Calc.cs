using System;

namespace groovydsl
{
    public class CalcEngine
    {
        public double Add (double a, double b)
        {
            return a+b;
        }

        public double Sub (double a, double b)
        {
            return a-b;
        }

        public double Mul (double a, double b)
        {
            return a*b;
        }

        public double Div(double a, double b)
        {
            return a/b;
        }
    }
}