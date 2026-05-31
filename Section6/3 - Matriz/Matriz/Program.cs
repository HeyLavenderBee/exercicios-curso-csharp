using System;
using System.Xml;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Type lines and columns count: ");
            string[] vect = Console.ReadLine().Split(" ");

            int m = int.Parse(vect[0]);
            int n = int.Parse(vect[1]);

            int[,] mat = new int[m, n];

            for(int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(line[j]);
                }
            }

            Console.WriteLine();
            Console.Write("Choose a number in the matrix: ");
            int matNumber = int.Parse(Console.ReadLine());

            for(int i = 0; i < m; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (mat[i, j] == matNumber)
                    {
                        Console.WriteLine("Position " + i + ", " + j);
                        if(j > 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (j < n - 1)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i > 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (i < m - 1)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }

        static void ExercicioTreinamento()
        {
            Console.Write("Digite a ordem n da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];
            int negativeCount = 0;

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(" ");

                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(vect[j]);
                    if (matriz[i, j] < 0)
                    {
                        negativeCount++;
                    }
                }
            }

            Console.WriteLine();

            Console.WriteLine("Main diagonal: ");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(matriz[i, i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Negative numbers = " + negativeCount);
        }
    }
}