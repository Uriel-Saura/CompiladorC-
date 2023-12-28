using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    public class Transicion
    {
        //atributtes
        private char SimbInf1;
        private char SimbSup1;
        private Estado Edo;

        //constructor
        public Transicion (char simb, Estado e)
        {
            SimbInf1 = simb;
            SimbSup1 = simb;
            Edo = e;
        }

        public Transicion (char simbInf1, char simbSup, Estado edo)
        {
            SimbInf1 = simbInf1;
            SimbSup1 = simbSup;
            Edo = edo;
        }

        public Transicion()
        {
            Edo = null;
        }

        //seters
        public void SetTransicion(char s1, char s2, Estado e)
        {
            SimbInf1 = s1;
            SimbSup1 = s2;
            Edo = e;
        }

        public void SetTransicion(char s1, Estado e)
        {
            SimbInf1 = s1;
            SimbSup1 = s1;
            Edo = e;

            return;
        }

        public char SimbInf { get => SimbInf1; set => SimbInf1 = value; }
        public char SimbSup { get => SimbSup1; set => SimbSup1 = value; }

        //getter
        public Estado GetEdoTrans(char s)
        {
            if (SimbInf1 <= s && s <= SimbSup1)
                return Edo;
            return null;
        }
        //sacamos el id del estado
        public int GetIdEdoTrans()
        {
            return Edo.IdEstado;
        }

        public char getInf()
        {
            return SimbInf1;
        }

        public char getSup()
        {
            return SimbSup1;
        }


    }
}
