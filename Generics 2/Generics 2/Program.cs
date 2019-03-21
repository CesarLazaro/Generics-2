using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2
{
    class Program
    {
        static void Main(string[] args)
        {
            generica<int> Entero = new generica<int>();
            int Resultado=Entero.Suma(2, 3);
            Console.WriteLine("Suma: " + Resultado);
            Resultado = Entero.Resta(2, 3);
            Console.WriteLine("Resta: " + Resultado);
            Resultado = Entero.Multiplicacion(2, 3);
            Console.WriteLine("Multiplicacion: " + Resultado);
            Resultado = Entero.Divicion(2, 3);
            Console.WriteLine("Divicion: " + Resultado);

            generica<double> Double = new generica<double>();
            Double Resultado2 = Double.Suma(3.1444, 6.576);
            Console.WriteLine("Suma: " + Resultado2);
            Resultado2 = Double.Resta(5.6766, 3);
            Console.WriteLine("Resta: " + Resultado2);
            Resultado2 = Double.Multiplicacion(2.2, 3);
            Console.WriteLine("Multiplicacion: " + Resultado2);
            Resultado2 = Double.Divicion(3.14, 3);
            Console.WriteLine("Divicion: " + Resultado2);

            Console.ReadKey();



        }
    }
}