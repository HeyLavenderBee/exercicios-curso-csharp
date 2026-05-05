using System.Globalization;

namespace MembrosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a cotação do dólar: ");
            ConversorDeMoeda.cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o valor em dólares: ");
            ConversorDeMoeda.valorDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Valor a ser pago em reais = "+ConversorDeMoeda.calcularValorReais().ToString("f2", CultureInfo.InvariantCulture));
        }
    }
}