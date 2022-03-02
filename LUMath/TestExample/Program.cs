using System;
using LUMath;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LUInt num_1 = new LUInt(5);
            LUInt num_2 = new LUInt(0.5f);
            Console.WriteLine(num_1.ScaledValue);
            Console.WriteLine(num_2.ScaledValue);
            Console.ReadKey();
        }
    }
}
