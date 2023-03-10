using System;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(args[0]);
            string letra = args[1];

            for (int i = 0; i < numero; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(letra);
                }
                Console.Write("\n");
            }
        }
    }
}
