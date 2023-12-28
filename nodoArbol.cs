using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class nodoArbol
    {
        public string Cadena;
        public int id;
        public List<nodoArbol> Hijos = new List<nodoArbol>();
        public bool hoja;
        public int anchoH;
        public int nivel;
        public int numHijos;

        public nodoArbol(int id, string Cadena, bool hoja, int nivel)
        {
            this.id = id;
            this.Cadena = Cadena;
            this.hoja = hoja;
            this.nivel = nivel;
            this.anchoH = 1;
            this.numHijos = 0;
           
        }

        public string getCadena()
        {
            return this.Cadena;
        }

        public List<nodoArbol> getHijos()
        {
            return this.Hijos;
        }

        public void setHoja(bool hoja)
        {
            this.hoja = hoja;
        }
        public void InsertarHijo(nodoArbol hijo)
        {
            this.Hijos.Add(hijo);
            this.numHijos++;
        }

        public void setCadena(string Cadena)
        {
            this.Cadena = Cadena;
        }

        public int getNivel()
        {
            return this.nivel;
        }

       
    }
}
