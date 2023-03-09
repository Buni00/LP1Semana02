using System;

namespace ManipulaVar
{
    class Program
    {
        static void Main(string[] args)
        {

            for ( int i = 0; i < args.Length; i++)
            {
                int x = Convert.ToInt32(args[i]);
                int a = 1 + x++;
                int b = --x - 1; 
                
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            
        }
    }
}

