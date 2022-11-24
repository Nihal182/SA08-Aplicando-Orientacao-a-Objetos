using System.Security.Cryptography;
using System;
using Treinamento.Matematica;

namespace ExemploNet

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xStr = Console.ReadLine();//UI
            string yStr = Console.ReadLine();//UI
            int x = Convert.ToInt32(xStr);
            int y = Convert.ToInt32(yStr);
            CalculadoraNet calc = new CalculadoraNet();
            int r = calc.Somar(x, y);
            
            Console.WriteLine(r.ToString()); //Saída

            Console.ReadLine();
        }

       // private static int Somar(int x, int y)
        //{
         //   return x + y;
            //BUSINESS

       // }
    }
}
