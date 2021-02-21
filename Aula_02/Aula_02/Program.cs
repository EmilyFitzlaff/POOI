using System;

namespace Aula_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercício 01:

            int inteiro = 12;
            char caracter = 'f';
            long numeroLong = 901;
            float numeroFloat = 990.99f;
            double numeroDouble = 90.98;

            Console.WriteLine("caracter = " + caracter);
            Console.WriteLine("inteiro = " + inteiro);
            Console.WriteLine("numeroLong = " + numeroLong);
            Console.WriteLine("numeroDouble = " + numeroDouble);

            //upcasting – casting implicito
            //char – int
            inteiro = caracter;
            Console.WriteLine("caracter 'f'  sendo visto como inteiro = " + inteiro);

            //downcasting – casting tem que ser explicito
            //float – int
            inteiro = (int)numeroFloat;
            Console.WriteLine("float 990.99f sendo visto como inteiro = " + inteiro);

            //int – byte
            byte b = (byte)inteiro;
            Console.WriteLine("inteiro " + inteiro + " sendo visto como byte = " + b);

            Console.WriteLine("--------------------------------");

            // exercício 02: 

            // declare e inicialize uma variável do tipo int, nomeada n1
            int n1 = 1;

            // declare e inicialize uma variável do tipo long nomeada n2
            long n2 = 5;

            // se n1 > n2 e n1 > 0, faca com que n1 receba o valor de n2
            // imprima um texto indicando a operação realizada
            if (n1 > (int)n2 && n1 > 0) {
                n1 = (int)n2;
                Console.WriteLine("N1 > N2 e N1 é maior que zero, desta forma, N1 = " + n1);
            }
            
            // se n2 > n1 ou n2 < 0, faca com que n2 receba o valor de n1
            // imprima um texto indicando a operação realizada

            else if ((int)n2 > n1 || (int)n2 < 0) {
                n2 = n1;
                Console.WriteLine("Se N2 > N1 ou N2 é maior que zero, então N2 = " + n2);
            }

            Console.WriteLine("--------------------------------");

            // exercício 03

            int idade = 22;
            char letra = 'A';
            double tamanho = 1.60;
            long numeroLongo = 555;
            bool legal = true;

            // explícito cast

            idade = (int)numeroLongo;  
            Console.WriteLine("Idade: " + idade);

            byte letraByte = (byte)letra;
            Console.Write("Letra Byte: " + letraByte);

            int iTamanho = (int)tamanho;
            Console.WriteLine("iTamanho: " + iTamanho);

            // automático cast

            double varA = 25;
            long varB = 1;
            int varC = 15564654;

            // operadores pré-fixado e pós-fixado;

            int A, B, C;
            A = 1;
            B = 2;
            C = 3;

            Console.WriteLine("A pré-fixado: " + ++A);
            Console.WriteLine("A pós-fixado: " + A++);
            Console.WriteLine("B pré-fixado: " + --B);
            Console.WriteLine("B pós-fixado: " + B--);

            // operadores or e and

            if(A > B || B < C)
            {
                Console.WriteLine("Você ganhou na loteria!");
            } 
            else if (B > C && A > 0)
            {
                Console.WriteLine("Reprovou em estrutura!");
            }

            // operador ternário

            C = A > B ? A : B;
            Console.WriteLine("C: " + C);

            // % com números float

            double resto = 152.50 % 2.5;
            Console.WriteLine("Resto: " + resto);

            // % com números short

            short shortResto = 10 % -5;
            Console.WriteLine("Short Resto: " + shortResto);

            Console.ReadKey();
        }
    }
}
