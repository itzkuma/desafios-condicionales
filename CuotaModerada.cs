using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoCuotaModeradora
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Copie su salario");
            double salario = Double.Parse(Console.ReadLine());

            Console.WriteLine("Su tarifa a pagar es:");

            if (salario < (877803 + 877803))
            {

                Console.WriteLine("Tarifa A");
            }
            else if  ((877803 * 2) <= salario && salario < (877803 * 5))
            {
                Console.WriteLine("Tarifa B");
            }
            else if (salario >= (877803 * 5))
            {

                Console.WriteLine("Tarifa C");
            }
        }
    }
}
    

