using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int a, b, c;

                Console.WriteLine("Digite valor 1: ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite valor 1: ");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite valor 1: ");
                c = Convert.ToInt32(Console.ReadLine());

                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.WriteLine("Os 3 lados formam um triangulo!\n");
                    if (a == b && a == c)
                        Console.WriteLine("Equilatero\n");
                        
                    else
                        if (a == b || a == c || b == c)
                        Console.WriteLine("Isosceles\n");
                    else
                        Console.WriteLine("Escaleno\n");
                
            }
                else
                    Console.WriteLine("Os 3 lados NAO formam um trinagulo!\n");
            Console.ReadLine();

        }
    }
}
