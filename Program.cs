using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dimantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o um numero impar");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O numero não é impar");
            }
            else
            {
                int espacos = num / 2;
                int X = 1;

                for(int i=0; i < num; i++)
                {
                    for(int j = 0; j<espacos; j++)
                    {
                        Console.Write(" ");
                    }
                for(int j = 0 ; j < X; j++) 
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();

                    if (i < num / 2)
                    {
                        espacos--;
                        X += 2;
                    }
                    else
                    {
                        espacos++;
                        X -= 2;
                    }
                    
                }
                Console.ReadLine();

            }

        }
    } 

}

