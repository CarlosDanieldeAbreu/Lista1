using System;

namespace SalarioFuncionario.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("Digite seu salário: ");
            string dinheiro = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("=======================================");
            Console.WriteLine("salário inicial:............." + dinheiro + " R$");
            double salario = Convert.ToDouble(dinheiro);
            double aumento = (salario * 0.15) / 100;
            Console.WriteLine("Aumento de:.................." + aumento + " R$");
            salario += aumento;
            Console.WriteLine("salário com o aumento:......." + salario + " R$");
            double desconto = (salario * 0.08) / 100;
            Console.WriteLine("Desconto de:.................." + desconto + " R$");
            salario -= desconto;
            Console.WriteLine("salário final:..............." + salario + " R$");
            Console.WriteLine("=======================================");
        }
    }
}
