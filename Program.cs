using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3_ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Digite o 1° valor: ");
            a = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("Digite o 2° valor: ");
                b = int.Parse(Console.ReadLine());
            }
            while (a >= b);
        }
    }
}
