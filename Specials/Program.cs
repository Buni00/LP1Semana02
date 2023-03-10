using System;

namespace Specials
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);

            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            Console.WriteLine(2* double.MaxValue);
            Console.WriteLine(double.MinValue);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            Console.WriteLine(short.MaxValue);
            int i= short.MaxValue;
            Console.WriteLine((short) (i+1));

            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);

            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);

            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);

            Console.WriteLine(float.NaN);

            float f1 , f2 ;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.0001f);

            

            
        }
    }
}
