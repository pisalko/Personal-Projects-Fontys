using System;

namespace trying
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 10;
            a = a + b;
            b = a + b;
            a = a - b;
            b = a - b;

            Console.Write(a);
            Console.Write(b);
            Console.ReadKey();

        }
    }
}
