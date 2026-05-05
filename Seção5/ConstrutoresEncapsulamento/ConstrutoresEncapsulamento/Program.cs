using System.Globalization;

namespace ConstrutoresEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.WriteLine("Entre número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial (s/n)? ");
            string depositoInicial = Console.ReadLine();
            double saldo = 0.0;
            if (depositoInicial == "s" || depositoInicial == "S")
            {
                Console.WriteLine("Entre o valor de depósito inicial: ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, nomeTitular, saldo);
            }
            else
            {
                conta = new ContaBancaria(numero, nomeTitular);
            }

            conta.NomeTitular = "JKgjdsklg";

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(saldo);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(saldo);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}