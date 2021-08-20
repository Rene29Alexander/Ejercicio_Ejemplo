using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Ejemplo
{
    public class Class1
    {
        public static void ListCollection()
        {
            Console.WriteLine("ingresa el numero del dia de la semana que desee imprimir: ");
            double numero = Convert.ToDouble(Console.ReadLine());

            if (numero == 1)
            {
                Console.WriteLine("Usted imprimio el dia Lunes.");
            }

            else if (numero == 2)
            {
                Console.WriteLine("Usted imprimio el dia Martes.");
            }

            else if (numero == 3)
            {
                Console.WriteLine("Usted imprimio el dia Miercoles.");
            }

            else if (numero == 4)
            {
                Console.WriteLine("Usted imprimio el dia Jueves.");
            }

            else if (numero == 5)
            {
                Console.WriteLine("Usted imprimio el dia Viernes.");
            }

            else if (numero == 6)
            {
                Console.WriteLine("Usted imprimio el dia Sabado.");
            }

            else if (numero == 7)
            {
                Console.WriteLine("Usted imprimio el dia Domingo.");
            }

            else
            {
                Console.WriteLine("El numero que ingreso no corresponde a un dia de la semana.");
            }

            Console.ReadKey();
        }
    }
}
