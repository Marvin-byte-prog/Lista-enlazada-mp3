using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_ReproduccionMP3.Clases
{
    class Lista
    {
        public Nodo primero;

        public Lista()
        {
            primero = null;
        }

        public void insertarCancion(object cancion)
        {
            Nodo nuevo = new Nodo((string)cancion);
            if(primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo nodoActual = primero.siguiente;
                if (nodoActual == null)
                {
                    primero.siguiente = nuevo;
                }
                else
                {
                    while(nodoActual.siguiente != null)
                    {
                        nodoActual = nodoActual.siguiente;
                    }
                    nodoActual.siguiente = nuevo;
                }
            }
        }//fin introduce cancion

        public void eliminar(object entrada)
        {
            Nodo actual, anterior;
            bool encontrado;
            //inicializa los apuntadores
            actual = primero;
            anterior = null;
            encontrado = false;
            //busqueda del nodo anterior
            while ((actual != null) && (!encontrado))
            {
                encontrado = (((string)actual.getDato() ==(string)(entrada)));

                if (!encontrado)
                {
                    anterior = actual;
                    actual = actual.siguiente;
                }
            }//fin while

            //enlace del nodo anterior con el siguientes
            if (actual != null)
            {
                if (actual == primero)
                {
                    primero = actual.siguiente;
                }
                else
                {
                    anterior.siguiente= actual.siguiente;
                }
                actual = null;
            }

        }//ejemplo de la clase

            public void eliminarCancion(int n)
            {
                if (primero != null)
                {
                    if (primero.siguiente == null)
                    {
                        primero = null;
                    }
                    else
                    {
                        Nodo puntero = primero;
                        int contador = 0;
                        while (contador < (n - 1))
                        {
                            puntero = puntero.siguiente;
                            contador++;
                        }
                        Nodo temp = puntero.siguiente;
                        puntero.siguiente = temp.siguiente;
                        temp.siguiente = null;
                    }
                
                }
            }
    }
}
