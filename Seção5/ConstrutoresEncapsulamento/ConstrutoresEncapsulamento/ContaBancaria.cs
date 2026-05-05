using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace ConstrutoresEncapsulamento
{
    internal class ContaBancaria
    {
        public int Numero { get; private set; }
        public string NomeTitular { get; set; }

        public double Saldo { get; private set; }

        /*
        public string NomeTitular
        {
            get {  return _nomeTitular; }
            set 
            { 
                if(value.Length > 0)
                {
                    _nomeTitular = value;
                }
            }
        }
        */

        public void setNomeTitular(string nome)
        {
            NomeTitular = nome;
        }
        
        public ContaBancaria(int numero, string nomeTitular)
        {
            Numero = numero;
            NomeTitular = nomeTitular;
        }

        public ContaBancaria(int numero, string nomeTitular, double depositoInicial) : this(numero, nomeTitular)
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double saldo)
        {
            Saldo += saldo;
        }

        public void Sacar(double saldo)
        {
            Saldo -= saldo + 5.0;
        }

        public override string ToString()
        {
            return "Conta " + Numero + ", Titular: " + NomeTitular + ", Saldo: $" + Saldo.ToString("f2", CultureInfo.InvariantCulture);
        }
    }
}
