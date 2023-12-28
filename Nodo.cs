using DocumentFormat.OpenXml.EMMA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class Nodo
    {
        string cadena;
        bool tnt;

        public Nodo()
        {
            cadena = "";
            tnt = false;
        }
        public Nodo(string cadena)
        {
            this.cadena = cadena;
        }

        public Nodo(string cadena, bool tnt)
        {
            this.cadena = cadena;
            this.tnt = tnt;
        }

        public void modTNT(bool tnt)
        {
            this.tnt = tnt;
        }

        //definimos los gets
        public string getCadena()
        {
            return this.cadena;
        }

        public bool getTNT()
        {
            return this.tnt;
        }

        //definimos los sets
        public void setCadena(string cadena)
        {
            this.cadena = cadena;
        }

        public void setTNT(bool tnt)
        {
            this.tnt = tnt;
        }


        //arbol

        public string Symbol { get; }
        public string Value { get; }
        public List<Nodo> Children { get; }

        public Nodo(string symbol, string value)
        {
            Symbol = symbol;
            Value = value;
            Children = new List<Nodo>();
        }

        public Nodo(string symbol, List<Nodo> children)
        {
            Symbol = symbol;
            Value = "";
            Children = children;
        }

        public void Print(int level = 0){
            Console.WriteLine(new string(' ', level) + Symbol);

            foreach(Nodo child in Children)
            {
                child.Print(level + 1);
            }

        }





    }


}
