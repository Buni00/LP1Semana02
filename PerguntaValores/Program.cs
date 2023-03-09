using System;

namespace PerguntaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            double a; 
            double r; 
            double Volume;
            double AreaSup;

            double pi = Math.PI;

            Console.WriteLine("Altura Cilindro: ");
            a = double.Parse( Console.ReadLine());
            Console.WriteLine("Raio Cilindro: ");
            r = double.Parse(Console.ReadLine());

            Volume = pi * Math.Pow(r,2) * a;  
            AreaSup = 2 * pi * r * (r + a);
        }
    }
}
