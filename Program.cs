using System;

namespace groovydsl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in the ultimate calc application!\nPlease select a job:\na) Add\nb) Sub\nc) Mul\nd) Div\nyour selection: ");
            string selection = Console.ReadLine();
            Console.WriteLine("please provide value for:\na parameter: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("b parameter: ");
            double b = double.Parse(Console.ReadLine());
            CalcEngine calc = new CalcEngine();
            switch(selection)
            {
                case "a": Console.WriteLine("result is: "+calc.Add(a,b));break;
                case "b": Console.WriteLine("result is: "+calc.Sub(a,b));break;
                case "c": Console.WriteLine("result is: "+calc.Mul(a,b));break;
                case "d": Console.WriteLine("result is: "+calc.Div(a,b));break;
            }
            Console.ReadKey();
        }
    }
}
