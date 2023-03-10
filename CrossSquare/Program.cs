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
                    if(j==1 && i==0)
                    {
                        Console.Write("X");
                    }
                    if(j==2 && i==1)
                    {
                        Console.Write("X");
                    }
                    if(j==3 && i==2)
                    {
                        Console.Write("X");
                    }
                    if(j==4 && i==3)
                    {
                        Console.Write("X");
                    }
                    if(j==5 && i==4)
                    {
                        Console.Write("X");
                    }
                    if(j==n-2)
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
