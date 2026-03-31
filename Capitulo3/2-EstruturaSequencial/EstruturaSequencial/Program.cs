using System;
using System.Collections.Concurrent;
using System.Globalization;

namespace Capitulo1 {
    class Program {
        static void Main(string[] args) {
            // Exercício 1
            Console.WriteLine("Exercício 1");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine("Soma = " + soma);

            // Exercício 2
            Console.WriteLine("Exercício 2");
            double raio, area, pi = 3.14159;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = pi * Math.Pow(raio, 2);
            Console.WriteLine("Area = "+area.ToString("F4", CultureInfo.InvariantCulture));

            // Exercício 3
            Console.WriteLine("Exercício 3");
            int a, b, c, d, diferenca;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = (a * b) - (c * d);
            Console.WriteLine("Diferenca = "+diferenca);

            // Exercício 4
            Console.WriteLine("Exercício 4");
            int numero, horasTrabalhadas;
            double valorHora, salario;

            numero = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horasTrabalhadas;
            Console.WriteLine("Number = "+ numero);
            Console.WriteLine("Salary = U$"+ salario.ToString("F2", CultureInfo.InvariantCulture));

            // Exercício 5
            Console.WriteLine("Exercício 5");
            double total;
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vet1[0]);
            int qtd1 = int.Parse(vet1[1]);
            double preco1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);
            int codigo2 = int.Parse(vet2[0]);
            int qtd2 = int.Parse(vet2[1]);
            double preco2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            total = (preco1*qtd1) + (preco2*qtd2);
            Console.WriteLine("Valor a pagar: R$"+total.ToString("F2", CultureInfo.InvariantCulture));

            // Exercício 6
            Console.WriteLine("Exercício 6");
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo;
            string[] vet3 = Console.ReadLine().Split(' ');
            A = double.Parse(vet3[0], CultureInfo.InvariantCulture);
            B = double.Parse(vet3[1], CultureInfo.InvariantCulture);
            C = double.Parse(vet3[2], CultureInfo.InvariantCulture);

            triangulo = (A * C) / 2;
            circulo = pi * Math.Pow(C, 2); //pi já foi definido em um exercício acima
            trapezio = ((A+B)*C)/2;
            quadrado = B*B;
            retangulo = A*B;
            Console.WriteLine("Triângulo: "+triangulo.ToString("f3",CultureInfo.InvariantCulture));
            Console.WriteLine("Cículo: "+circulo.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapézio: "+trapezio.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("Quadrado: "+quadrado.ToString("f3", CultureInfo.InvariantCulture));
            Console.WriteLine("Retângulo: "+retangulo.ToString("f3", CultureInfo.InvariantCulture));
        }
    }
}
