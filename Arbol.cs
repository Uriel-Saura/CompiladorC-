using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Arbol
    {
        public nodoArbol raiz;
        public int ancho;
        public int niveles;
        public int indiceAnalisis;
        public List<nodoArbol> nodos = new List<nodoArbol>();
        public int indexid = 0;


        public Arbol(nodoArbol raiz)
        {
            this.raiz = raiz;
            this.ancho = 1;
            this.niveles = 0;
            nodos.Add(raiz);
        }

        public nodoArbol AgregarNodo(string cadena, int nivel)
        {
            this.indexid++;
            nodoArbol newNode = new nodoArbol(this.indexid, cadena, false, nivel);
            
            if (nivel > this.niveles)
                this.niveles = nivel;


            return newNode;
        }


    }
}
