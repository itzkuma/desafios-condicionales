using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simulacro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Copie su salario mensual");
            double salario = Double.Parse(Console.ReadLine());
            Console.WriteLine("su tipo de contrato es:");
            Console.WriteLine("Copie 1 si su contrato es dependiente");
            Console.WriteLine("Copie 2 si su contrato es independiente");
            int contrato = int.Parse (Console.ReadLine());
            int riesgo= 0;
            double claseRiesgo=0;
            double salariorealmensual = 0;

            if (contrato == 2){
                Console.WriteLine("Ingrese su clase de riesgo... de 1 a 5");
                riesgo = int.Parse (Console.ReadLine());

            }
            if (riesgo == 1){
                claseRiesgo = (0.00522);
            }
            else if (riesgo == 2)
            {
                claseRiesgo = (0.010044);
            }
            else if (riesgo == 3)
            {
                claseRiesgo = (0.02436);
            }
            else if (riesgo == 4)
            {
                claseRiesgo = (0.0435);
            }
            else if (riesgo == 5)
            {
                claseRiesgo = (0.0696);
            }

            Console.WriteLine("su salario real mensual es:");
            //salario mensual - deducciones
            double cotizacion = (salario * 0.4);
            if (cotizacion < 877803 ){
                cotizacion = salario;
            }
            double pension1 = (cotizacion *0.04);
            double pension2 = (cotizacion * 0.16);
            double eps1 = (cotizacion * 0.04);
            double eps2 = (cotizacion * 0.125);
            double arl1 = (0);
            double arl2 = (cotizacion * claseRiesgo);

            double deduccion1 = pension1 + eps1 + arl1;
            double deduccion2 = pension2 + eps2 + arl2;

            if (contrato==1 ){
                salariorealmensual = (salario - deduccion1);
            }
            else if (contrato == 2){
                salariorealmensual = (salario - deduccion2);
            }

            Console.WriteLine(salariorealmensual);

            Console.WriteLine("Su salario anual con deducciones y con bonificación es:");
            double salarioRealAnual = 0;

            if (contrato == 1)
            {
                salarioRealAnual = (salario + deduccion1 +salario);
            }
            else if (contrato == 2)
            {
                salarioRealAnual = (salario + deduccion2);
            }

            Console.WriteLine(salarioRealAnual);







            //877803 
        }
    }
 }

