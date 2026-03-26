using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string numeroDados = args[0];
            string semente = args[1];

            int numeroDadosInt = int.Parse(numeroDados);
            int sementeInt = int.Parse(semente);

            Random dado = new Random(sementeInt);

            int valorTotal = 0;

            for(int i = 0; i < numeroDadosInt; i++)
            {
                int valor = dado.Next(1,7);
                valorTotal += valor;
            }
            
            Console.WriteLine(valorTotal);
        }
    }
}