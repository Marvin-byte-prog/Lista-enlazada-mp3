using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_ReproduccionMP3.Clases
{
    class Nodo
    {
        public object dato;
        public Nodo siguiente;

        public Nodo (object n)
        {
            dato = n;
            siguiente = null;
        }
        public Nodo (object n, Nodo nodo)
        {
            dato = n;
            siguiente = nodo;
        }

        public object getDato()
        {
            return dato;
        }
    }
}
