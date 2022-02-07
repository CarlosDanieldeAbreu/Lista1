using System;

namespace Imobiliaria.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("Imobiliária Imóbilis");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("===============================");
            Console.WriteLine("Informe as dimensões do terreno");
            Console.WriteLine("");
            Console.WriteLine("Dimensão da base do terreno:");
            string Altura = Console.ReadLine();
            Console.WriteLine("Dimensão da altura do terreno:");
            string Largura = Console.ReadLine();

            float A = Convert.ToSingle(Altura);
            float B = Convert.ToSingle(Largura);
            float resultado = A * B;
            Console.WriteLine("");
            Console.WriteLine("===============================");
            Console.WriteLine("ÁREA DO TERRENO:");
            Console.WriteLine(resultado + "M");
            Console.WriteLine("===============================");
        }
    }
}
