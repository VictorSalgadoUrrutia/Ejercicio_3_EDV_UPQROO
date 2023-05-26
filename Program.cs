using System;

namespace Ejercicio_4_EDA
{
    internal class Program
    {
        class Nodo
        {
            public int Valor;
            public Nodo Izquierdo;
            public Nodo Derecho;

            public Nodo(int valor)
            {
                Valor = valor;
                Izquierdo = null;
                Derecho = null;
            }
        }

        class ArbolBinario
        {
            public Nodo Raiz;

            public ArbolBinario()
            {
                Raiz = null;
            }

            public int ContarNodos()
            {
                return ContarNodosRecursivo(Raiz);
            }

            private int ContarNodosRecursivo(Nodo nodo)
            {
                if (nodo == null)
                    return 0;

                int izquierdo = ContarNodosRecursivo(nodo.Izquierdo);
                int derecho = ContarNodosRecursivo(nodo.Derecho);

                return 1 + izquierdo + derecho;
            }
        }


        static void Main(string[] args)
        {
            // Crear un árbol binario de ejemplo
            ArbolBinario arbol = new ArbolBinario();
            arbol.Raiz = new Nodo(1);
            arbol.Raiz.Izquierdo = new Nodo(2);
            arbol.Raiz.Derecho = new Nodo(3);
            arbol.Raiz.Izquierdo.Izquierdo = new Nodo(4);
            arbol.Raiz.Izquierdo.Derecho = new Nodo(5);
            arbol.Raiz.Derecho.Izquierdo = new Nodo(6);
            arbol.Raiz.Derecho.Derecho = new Nodo(7);

            // Contar los nodos del árbol
            int numeroNodos = arbol.ContarNodos();

            Console.WriteLine("Número de nodos en el árbol: " + numeroNodos);








        }
    }
}
