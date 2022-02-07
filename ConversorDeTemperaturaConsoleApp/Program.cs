using System;

namespace ConversorFahrenheit.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("Conversor de Celsius para Fahrenheit");
            Console.WriteLine("====================================");
            Console.WriteLine("");
            Console.WriteLine("Digite a temperatura:");
            string TempCelsius = Console.ReadLine();
            Console.Clear();

            float celsius = Convert.ToSingle(TempCelsius);
            float conversor = (celsius * 1.8f) + 32;

            Console.WriteLine("====================================");
            Console.WriteLine("Temperatura em Celsius:................." + celsius + "°C");
            Console.WriteLine("Temperatura convertida em Fahrenheit:..." + conversor + "°F");
        }
    }
}
