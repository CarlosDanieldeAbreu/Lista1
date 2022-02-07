using System;

namespace Padaria.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================");
            Console.WriteLine("Padaria Hotpão");
            Console.WriteLine("========================");
            Console.WriteLine("");
            
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("Quantidade de pãozinhos:");
            string qtdPaozinho = Console.ReadLine();
            const decimal ValorPaozinho = 0.12m;
            int paozinho = Convert.ToInt32(qtdPaozinho);
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("");

            Console.WriteLine("========================");
            Console.WriteLine("Quantidade de broas:");
            string qtdBroa = Console.ReadLine();
            const decimal ValorBroa = 1.50m;
            int broa = Convert.ToInt32( qtdBroa);
            Console.WriteLine("========================");
            Console.WriteLine("");
            Console.Clear();
            const decimal PorcentoParaGuardar = 0.10m;

            decimal resultadoPaozinho = paozinho * ValorPaozinho;
            decimal resultadoBroa = broa * ValorBroa;
            decimal totalPaoBroa = resultadoBroa + resultadoPaozinho;
            decimal poupanca = (totalPaoBroa * PorcentoParaGuardar) / 100;

            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("Pãozinhos");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("Quantidade de pãozinhos:." + qtdPaozinho);
            Console.WriteLine("Preço:..................." + ValorPaozinho + " R$");
            Console.WriteLine("Valor arrecadado no dia:." + resultadoPaozinho + " R$");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("Broas");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("Quantidade de Broas:....." + qtdBroa);
            Console.WriteLine("Preço:..................." + ValorBroa + " R$");
            Console.WriteLine("Valor arrecadado no dia:." + resultadoBroa + " R$");
            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");

            Console.WriteLine("¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨¨");
            Console.WriteLine("Total arrecadado no dia:........" + totalPaoBroa + " R$");
            Console.WriteLine("10% do Total arrecadado no dia:." + poupanca + " R$");
        }
    }
}
