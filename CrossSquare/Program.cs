using System;

namespace CrossSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(args[0]);

            for (int i = 0; i<n ; i++)
            {
                Console.Write("#");
            }            
            Console.WriteLine("");


            for(int i=0; i<n-2; i++)
            {
                for(int j = 1; j<=n; j++)
                {
                    if(j==1)
                    {
                        Console.Write("#");
                    }
                    if(j==n-1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("");

            }



            for (int i = 0; i<n ; i++)
            {
                Console.Write("#");
            }
        }
    }
}
