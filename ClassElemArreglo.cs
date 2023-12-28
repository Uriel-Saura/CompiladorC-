using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class ClassElemArreglo
    {
        string simbolo;
        Nodo InfSimbolo;
        bool t;
        List<Nodo> ListD = new List<Nodo>();

        public ClassElemArreglo()
        {
            simbolo = "";
            t = false;
        }

        public ClassElemArreglo(Nodo InfSimbolo, List<Nodo> ListD)
        {
            this.InfSimbolo = InfSimbolo;
            this.ListD = ListD;
        }

        //declaramos los gets
        public List<Nodo> getListD()
        {
            return this.ListD;
        }

        public Nodo getNodo()
        {
            return this.InfSimbolo;

        }

        public void setInfSimbolo(Nodo InfSimbolo)
        {
            this.InfSimbolo = InfSimbolo;
        }

        public void setLisD(List<Nodo> ListD)
        {
            this.ListD = ListD;
        }






    }
}
