using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero a ser somado: ");

            int numero1 = Convert.ToInt32(Console.ReadLine());
            int numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"O resutado da somá é {Soma(numero1, numero2)}");


            Console.WriteLine("Aperte Enter para Finaizar");
            Console.ReadLine();
        }

        public static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

    }
}
