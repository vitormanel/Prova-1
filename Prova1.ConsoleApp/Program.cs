using System;

namespace Prova1.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Prova 1 - Academia do programador - Vitor Manuel R. \n");

            String opcao;
            do
            {
                int a, b, c;

                Console.WriteLine("Digite o Primeiro valor: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o Segundo valor: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite o Terceiro valor: ");
                c = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite 1 para verificar o tipo do triangulo.");
                Console.WriteLine("Digite S para sair");
                opcao = Console.ReadLine();

                if (opcao.Equals("s", StringComparison.InvariantCultureIgnoreCase))
                {
                    break;
                }

                if (opcao == "1")
                {
                    Console.WriteLine(" Os 3 lados formam um triangulo! \n");

                    //Eqüilátero: Todos os lados iguais (Funcionando!)
                    if (a == b && a == c)
                    {
                        Console.WriteLine(" Os 3 lados formam um Equilatero! ");
                        Console.ReadLine();
                    }

                    //Isósceles: Dois lados iguais (Funcionando)
                    else if (a == b || a == c || b == c)
                    {
                        Console.WriteLine(" Os 3 lados formam um Isoceles! ");
                        Console.ReadLine();
                    }

                    //Escaleno: Todos os lados diferentes (Funcionando!)
                    else if (a != b && a != c && c != b)
                    {
                        Console.WriteLine(" Os 3 lados formam um Escaleno! ");
                        Console.ReadLine();
                    }
                    //Lados invalidos
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Triangulo invalido:\n");
                        Console.WriteLine("Os 3 lados nao formam um triangulo!");
                        Console.ReadLine();
                        Console.ResetColor();
                    }
                    Console.ReadLine();
                }
            } while (opcao == "1" || opcao == "S");
        }
    }
}
