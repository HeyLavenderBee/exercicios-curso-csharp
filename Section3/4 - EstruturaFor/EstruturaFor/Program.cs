using System;
using System.Globalization;

namespace EstruturaFor {
    class Program {
        static void Main() {
            Exercicio7();
        }

        static void Exercicio1() {
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i <= x; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }

        static void Exercicio2() {
            int n = int.Parse(Console.ReadLine());
            int countIn = 0;
            int countOut = 0;
            for (int i = 0; i < n; i++) {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20) {
                    countIn++;
                } else {
                    countOut++;
                }
            }
            Console.WriteLine(countIn + " in");
            Console.WriteLine(countOut + " out");
        }

        static void Exercicio3() {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                float a = float.Parse(vet[0], CultureInfo.InvariantCulture);
                float b = float.Parse(vet[1], CultureInfo.InvariantCulture);
                float c = float.Parse(vet[2], CultureInfo.InvariantCulture);
                float media = (a * 2 + b * 3 + c * 5) / (2 + 3 + 5);
                Console.WriteLine(media.ToString("f1", CultureInfo.InvariantCulture));
            }
        }
        static void Exercicio4() {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                int a = int.Parse(vet[0]);
                int b = int.Parse(vet[1]);
                float divisao = (float)a / b;
                if (b == 0) {
                    Console.WriteLine("Divisão impossível");
                } else {
                    Console.WriteLine(divisao);
                }
            }
        }

        static void Exercicio5() {
            int n = int.Parse(Console.ReadLine());
            int fatorial = 1;
            for (int i = 1; i <= n; i++) {
                fatorial *= i;
            }
            Console.WriteLine(fatorial);
        }

        static void Exercicio6() {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <=n; i++) {
                if (n % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
        static void Exercicio7() {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                Console.WriteLine(i+" "+Math.Pow(i, 2)+" "+Math.Pow(i, 3));
            }
        }
    }
}