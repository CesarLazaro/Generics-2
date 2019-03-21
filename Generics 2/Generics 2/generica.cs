using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_2
{
    public class generica <T> where T:struct
    {
        public T resultado;

        public T Suma ( T a,  T b) 
        {
            resultado = (dynamic)a + (dynamic)b;
            return resultado;
        }

        public T Resta(T a, T b)
        {
            resultado = (dynamic)a - (dynamic)b;
            return resultado;
        }

        public T Multiplicacion(T a, T b)
        {
            resultado = (dynamic)a * (dynamic)b;
            return resultado;
        }

        public T Divicion(T a, T b)
        {
            resultado = (dynamic)a / (dynamic)b;
            return resultado;
        }

    }
}
