using System;
using LUMath;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LUInt num = 500;
            LUInt num_1 = num/new LUInt(0.3f);
            LUInt num_2 = num / new LUInt(-0.3f);
            Console.WriteLine(num_1.ScaledValue);
            Console.WriteLine(num_1.RawInt);
            Console.WriteLine(num_1.RawFloat);
            Console.WriteLine("_______________");
            Console.WriteLine(num_2.ScaledValue);
            Console.WriteLine(num_2.RawInt);
            Console.WriteLine(num_2.RawFloat);
            Console.ReadKey();
        }
    }
}
