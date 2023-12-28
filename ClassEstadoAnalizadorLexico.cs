using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class ClassEstadoAnalizadorLexico
    {
        public int EdoActual;
        public int token;
        public char CaracterActual;
        public Stack<int> Pila;
        public int EdoTransicion;
        public int FinLexema;
        public int IndiceCaracterActual;
        public int IniLexema;
        public string Lexema;
        public bool PasoPorEdoAcept;
    }
}
