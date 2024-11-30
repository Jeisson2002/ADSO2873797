using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ingresa un número:");
                int num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("El número {0} es par.", num);
                }
                else
                {
                    Console.WriteLine("El número {0} es impar.", num);
                }
                Console.ReadKey();
            }
        }
    }
