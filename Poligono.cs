using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Capitulo_10
{
    public class Poligono
    {
        private int numLados;
        private double longitudLado;

        public Poligono(int numLados, double longitudLado)
        {
            this.numLados = numLados;
            this.longitudLado = longitudLado;
        }

        public Poligono(int numLados) : this(numLados, 0.0)
        {
        }

        public Poligono() : this(0, 0.0)
        {
        }
    }

}
