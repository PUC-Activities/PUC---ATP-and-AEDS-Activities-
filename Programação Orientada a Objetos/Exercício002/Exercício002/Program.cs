using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício002
{
    internal class Program
    {
        static void Menu()
        {
            Console.WriteLine("1 - Somar dois numeros ");
            Console.WriteLine("2 - O maior de dois números");
            Console.WriteLine("3 - Somar N números");
            Console.WriteLine("4 - Contador de pares de uma sequência");
            Console.WriteLine("0 - Sair");
        }

        static double SomarNumeros(double num1, double num2)
        {
            return num1 + num2;
        }

        static bool MaiorNumero(double num1, double num2)
        {
            return num1 > num2;
        }

        static void ContaPares()
        {

        }
        static void Main(string[] args)
        {
            int opcao, quantidadeNumeros, contadorDosPares = 0;
            double num1, num2, num3, somaDeNumeros = 0;

            Console.WriteLine("Escolha uma opção:");
            Menu();
            opcao = int.Parse(Console.ReadLine());

            while (opcao != 0)
            {
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o numero 1 e 2:");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());

                        Console.WriteLine($"A soma é {SomarNumeros(num1, num2)}"); 
                        break;

                    case 2:

                        Console.WriteLine("Digite o numero 1 e 2:");
                        num1 = double.Parse(Console.ReadLine());
                        num2 = double.Parse(Console.ReadLine());

                        bool ehmaior = MaiorNumero(num1, num2);

                        if (ehmaior)
                        {
                            Console.WriteLine("O numero 1 é maior");
                        }
                        else
                        {
                            Console.WriteLine("O numero 2 é maior");
                        }

                        break; 

                    case 3:

                        Console.WriteLine("Quantos números deseja somar?");
                        quantidadeNumeros = int.Parse(Console.ReadLine());

                        for (int i = 0; i < quantidadeNumeros; i++)
                        {
                            Console.WriteLine("Digite o número: ");
                            num3 = double.Parse(Console.ReadLine());

                            somaDeNumeros += num3;
                        }
                        Console.WriteLine($"A soma total é {somaDeNumeros}");

                        break;

                    case 4:

                        Console.WriteLine("Quantos números possuem na sequência??");
                        quantidadeNumeros = int.Parse(Console.ReadLine());

                        for (int i = 0; i < quantidadeNumeros; i++)
                        {
                            Console.WriteLine("Digite o número: ");
                            num3 = double.Parse(Console.ReadLine());

                            if (num3 % 2 == 0)
                            {
                                contadorDosPares++;
                            }
                        }

                        Console.WriteLine($"A sequencia possui {contadorDosPares} numeros pares");

                        break;
                    default:
                        Console.WriteLine("Numero inválido, digite novamente");
                        break;
                }

                Console.WriteLine("Escolha uma opção:");
                Menu();
                opcao = int.Parse(Console.ReadLine());
            }
        }
    }
}
