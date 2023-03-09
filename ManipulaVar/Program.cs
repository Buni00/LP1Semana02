using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(args.Length);
            
            Console.WriteLine(x++);
            Console.WriteLine(--x);
        }
    }
}
