using System;

namespace MethodOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 1;
            var intAnswer = Add(a, b);
            Console.WriteLine($"Integer Answer: {intAnswer}");

            var c = 25.5m;
            var d = 32.2m;
            var decimalAnswer = Add(c, d);
            Console.WriteLine($"Decimal Answer: {decimalAnswer}");

            var stringAnswer = Add(a, b, true);
            Console.WriteLine(stringAnswer);
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }
        public static string Add(int a, int b, bool currency)
        {
            if (currency)
            {
                switch (a + b)
                {
                    case 1:
                        return $"{a + b} dollar";
                    default:
                        return $"{a + b} dollars";
                }
            }
            else
            {
                return $"{a+b}";
            }
        }
    }
}
