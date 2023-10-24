using ejercicio2Bucles.servicios;

namespace ejercicio2Bucles.controladores
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            int num2;

            operacionesInterfaz mi = new operacionesImplementacion();

            num1 = mi.NumeroReal();

            num2 = mi.NumeroEntero();

            mi.Calculo(num1,num2);
        }
    }
}
