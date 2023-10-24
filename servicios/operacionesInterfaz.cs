using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2Bucles.servicios
{
    internal interface operacionesInterfaz
    {
        public double NumeroReal();

        public int NumeroEntero();

        public void Calculo(double numero1,int numero2);
    }
}
