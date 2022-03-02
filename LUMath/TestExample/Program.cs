using System;
using LUMath;

namespace TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LUInt num_1 = 5;
            LUInt num_2 = (LUInt)0.5f;
            Console.WriteLine((num_1 / num_2).ToString());
            Console.ReadKey();
        }
    }
}
