using System;

namespace Session_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("---- Method Group Delegate ----");

            Operation add = MathOperation.Add;
            Operation sub = MathOperation.Subtract;
            Operation mul = MathOperation.Multiply;
            Operation div = MathOperation.Divide;

            Console.WriteLine(calculator.Calculate(10, 5, add));
            Console.WriteLine(calculator.Calculate(10, 5, sub));
            Console.WriteLine(calculator.Calculate(10, 5, mul));
            Console.WriteLine(calculator.Calculate(10, 5, div));

            Console.WriteLine("---- Lambda Expression ----");

            int result = calculator.Calculate(10, 5, (a, b) => a + b);
            Console.WriteLine(result);

            result = calculator.Calculate(10, 5, (a, b) => a - b);
            Console.WriteLine(result);

            Console.WriteLine("---- Multicast Delegate ----");

            Operation op = MathOperation.Add;
            op += MathOperation.Subtract;
            op += MathOperation.Multiply;

            foreach (var method in op.GetInvocationList())
            {
                Console.WriteLine(calculator.Calculate(10, 5, (Operation)method));
            }

            Console.WriteLine("---- Func Delegate ----");

            Func<int, int, int> addFunc = (a, b) => a + b;
            Console.WriteLine(addFunc(10, 5));

            Console.WriteLine("---- Predicate Delegate ----");

            Predicate<int> isEven = x => x % 2 == 0;
            Console.WriteLine(isEven(10));

            Console.WriteLine("---- Action Delegate ----");

            Action<string> print = message => Console.WriteLine(message);
            print("Calculator Finished");

            Console.ReadLine();
        }
    }
}