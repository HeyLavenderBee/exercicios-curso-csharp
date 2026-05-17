using System;

namespace EstruturaWhile {
    class Program {
        static public void Main(string[] args) {
            // exercícios separados em funções. Chame uma função para ver cada exercício.
            Exercicio1();
        }

        static void Exercicio1() {
            string senha = Console.ReadLine();
            
            while(senha != "2002") {
                Console.WriteLine("Senha inválida");
                senha = Console.ReadLine();
            }
            Console.WriteLine("Acesso permitido");
        }

        static void Exercicio2() {
            string[] vet = Console.ReadLine().Split(" ");
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro");
                } else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo");
                } else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro");
                } else if (x > 0 && y < 0) {
                    Console.WriteLine("Quarto");
                }
                vet = Console.ReadLine().Split(" ");
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }
        }

        static void Exercicio3() {
            int escolha = int.Parse(Console.ReadLine());
            int alcool = 0, gasolina = 0, diesel = 0;

            while (escolha != 4) {
                if (escolha == 1) {
                    alcool++;
                } else if (escolha == 2) {
                    gasolina++;
                } else if (escolha == 3) {
                    diesel++;
                } else {
                    Console.WriteLine("Código inválido, digite outro: ");
                }
                escolha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADA");
            Console.WriteLine("Alcool: "+alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);
        }
    }
}
