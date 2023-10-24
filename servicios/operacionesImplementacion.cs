using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Bucles.servicios
{
    internal class operacionesImplementacion : operacionesInterfaz
    {
        public void Calculo(double numero1, int numero2)
        {
            int i;
            double operacion=0;
            for (i = 0; i <= numero2; i++)
            {
                operacion = numero1 * numero1;
            }

            Console.WriteLine(numero1);
            Console.WriteLine("El numero {0} elevado a {1} es:{2}",numero1,numero2,operacion);
        }

        public int NumeroEntero()
        {
            int num;

            Console.WriteLine("Introduzca un número entero: ");
            num=Int32.Parse(Console.ReadLine());

            return num;
        }

        public double NumeroReal()
        {
            double num;

            Console.WriteLine("Introduzca un número real");
            num=Double.Parse(Console.ReadLine());

            return num;

        }
    }
}
