using System;
using System.Globalization;

namespace EstruturaCondicional {
    class Program {
        public static void Main(string[] args) {
            // Exercício 1
            Console.WriteLine("Exercício 1");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 < 0) {
                Console.WriteLine("O número é negativo.");
            } else {
                Console.WriteLine("O número é positivo");
            }

            // Exercício 2
            Console.WriteLine();
            Console.WriteLine("Exercício 2");
            int n2 = int.Parse(Console.ReadLine());
            if (n2 % 2 == 0) {
                Console.WriteLine("O número é par");
            } else {
                Console.WriteLine("O número é ímpar");
            }

            // Exercício 3
            Console.WriteLine();
            Console.WriteLine("Exercício 3");
            string[] vet1 = Console.ReadLine().Split(' ');
            int a = int.Parse(vet1[0]);
            int b = int.Parse(vet1[1]);
            if (a % b == 0 || b % a == 0) {
                Console.WriteLine("São múltiplos");
            } else {
                Console.WriteLine("Não são múltiplos");
            }

            // Exercício 4
            Console.WriteLine();
            Console.WriteLine("Exercício 4");
            string[] vet2 = Console.ReadLine().Split(' ');
            int hora_inicial = int.Parse(vet2[0]);
            int hora_final = int.Parse(vet2[1]);
            int duracao = 0;
            if (hora_final > hora_inicial) {
                duracao = hora_final - hora_inicial;
            } else if (hora_final < hora_inicial) {
                duracao = 24 - hora_inicial + hora_final;
            } else {
                duracao = 24;
            }

            Console.WriteLine($"O jogo durou {duracao} hora(s)");

            // Exercício 5
            Console.WriteLine();
            Console.WriteLine("Exercício 5");
            string[] vet3 = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet3[0]);
            int qtd = int.Parse(vet3[1]);
            double total = 0;
            if (codigo == 1) {
                total = qtd * 4.0;
            } else if (codigo == 2) {
                total = qtd * 4.5;
            } else if (codigo == 3) {
                total = qtd * 5.0;
            } else if (codigo == 4) {
                total = qtd * 2.0;
            } else {
                total = qtd * 1.5;
            }
            Console.WriteLine("Total: R$" + total.ToString("f2", CultureInfo.InvariantCulture));

            // Exercício 6
            Console.WriteLine();
            Console.WriteLine("Exercício 6");
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (n3 >= 0 && n3 <= 25) {
                Console.WriteLine("Intervalo (0,25]");
            } else if (n3 <= 50) {
                Console.WriteLine("Intervalo (25,50]");
            } else if (n3 <= 75) {
                Console.WriteLine("Intervalo (50,75]");
            } else if (n3 <= 100) {
                Console.WriteLine("Intervalo (75,100]");
            } else {
                Console.WriteLine("Fora de intervalo");
            }

            // Exercício 7
            Console.WriteLine();
            Console.WriteLine("Exercício 7");
            string[] vet4 = Console.ReadLine().Split(' ');
            double x = double.Parse(vet4[0], CultureInfo.InvariantCulture);
            double y = double.Parse(vet4[1], CultureInfo.InvariantCulture);
            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            } else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            } else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            } else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            } else if (x == 0) {
                Console.WriteLine("Eixo X");
            } else if (y == 0) {
                Console.WriteLine("Eixo Y");
            } else {
                Console.WriteLine("Q4");
            }

            // Exercício 8
            Console.WriteLine();
            Console.WriteLine("Exercício 8");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double imposto = 0;

            if (salario <= 2000) {
                imposto = 0.0;
            } else if (salario <= 3000) {
                imposto = (salario - 2000) * 0.08;
            } else if (salario <= 4500) {
                imposto = (salario - 3000) * 0.18 + 1000 * 0.08;
            } else {
                imposto = (salario - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (salario <= 2000) {
                Console.WriteLine("Isento");
            } else {
                Console.WriteLine("R$" + imposto.ToString("f2", CultureInfo.InvariantCulture);
            }
        }
    }
}
