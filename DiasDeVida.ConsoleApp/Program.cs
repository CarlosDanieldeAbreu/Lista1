using System;

namespace DiasDeVida.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("Veja quantos anos de vida você tem!!!");
            Console.WriteLine("=====================================");
            Console.WriteLine("");
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Digite sua idade:");
            string idade = Console.ReadLine();
            Console.Clear();

            int idad = Convert.ToInt32(idade);
            int diasDeVida = idad * 365;
            Console.WriteLine("=====================================");
            Console.WriteLine(nome + ", você já viveu " + diasDeVida + " dias em " + idade + " anos!!!");
            Console.WriteLine("=====================================");
        }
    }
}
