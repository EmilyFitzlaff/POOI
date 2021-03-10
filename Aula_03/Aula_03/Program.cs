using System;

namespace Aula_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // exercício 01
            String nome, rg, dataNascimento;
            char sexo;
            int tipoContratacao;
            double salario;

            Console.WriteLine("Informe seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Informe seu RG: ");
            rg = Console.ReadLine();

            Console.WriteLine("Informe sua data de nascimento: ");
            dataNascimento = Console.ReadLine();

            Console.WriteLine("Informe 'F' para Feminino ou 'M' para masculino: ");
            sexo = Console.ReadKey().KeyChar;

            Console.WriteLine("Tipo de Contratação: ");
            tipoContratacao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
