using System;

namespace Aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercício 01
            int[] arrayNumeros = new int[5];

            arrayNumeros[0] = 0;
            arrayNumeros[1] = 34;
            arrayNumeros[2] = 21;
            arrayNumeros[3] = 45;
            arrayNumeros[4] = 15;

            for (int i = 0; i <= arrayNumeros.Length - 1; i++)
            {
                Console.WriteLine("Índice: " + arrayNumeros[i]);
            }

            Console.WriteLine("-------------------------");

            // exercício 02
            String[] arrayEmails = {"1: Cliente 1 Email: cliente1@yahoo.com.br",
                                    "2: Cliente 2 Email: cliente2@yahoo.com.br",
                                    "3: Cliente 3 Email: cliente3@yahoo.com.br",
                                    "4: Cliente 4 Email: cliente4@yahoo.com.br",
                                    "5: Cliente 5 Email: cliente5@yahoo.com.br" };

            for (int i = 0; i <= arrayEmails.Length - 1; i++)
            {
                Console.WriteLine(arrayEmails[i]);
            }

            Console.WriteLine("-------------------------");

            // exercício 03

            int[,] arrayBidimensional = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i <= arrayBidimensional.GetLength(0) - 1; i++)
            {
                for (int j = 0; j <= arrayBidimensional.GetLength(1) - 1; j++)
                {
                    Console.WriteLine("Posição: " + i + " - " + j + ": " + arrayBidimensional[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}
