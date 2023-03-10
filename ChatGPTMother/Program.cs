using System;

namespace ChatGPTMother
{
    class Program
    {
        static void Main(string[] args)
        {
            string question1 = "Whats your name?";
            string question2 = "1+1?";
            string question3 = "2+2?";
            string question4 = "2+1?";
            string exit = "EXIT";

            while(true)
            {
                Console.WriteLine("Ask me a question");
                string answer = Console.ReadLine();

                if (answer == question1)
                    Console.WriteLine("I'm ChatGPTMother! \n");

                else if (answer == question2)
                    Console.WriteLine("2! \n");

                else if (answer == question3)
                    Console.WriteLine("4! \n");    

                else if (answer == question4)
                    Console.WriteLine("3! \n");
                else if (answer == exit)
                    break;    
                
                else
                    Console.WriteLine("Dont know the answer \n");


            }
            
        
            
            
        }
    }
}
