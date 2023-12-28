using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    class AnalizadorLexico
    {

        private int token, EdoActual, EdoTransicion;
        private string CadenaSigma;
        public string Lexema;
        private bool PasoPorEdoAcept;
        private int IniLexema, FinLexema, IndiceCaracterActual;
        private char CaracterActual;
        private Stack<int> Pila = new Stack<int>();
        private AFD AutomataFD;

        public AnalizadorLexico()
        {
            CadenaSigma = "";
            PasoPorEdoAcept = false;
            IniLexema = FinLexema = -1;
            IndiceCaracterActual = -1;
            token = -1;
            Pila.Clear();
            AutomataFD = null;
        }

        public AnalizadorLexico(string sigma, string FileAFD, int idAFD)
        {
            AutomataFD = new AFD();
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(FileAFD, idAFD);
        }
        public AnalizadorLexico(string sigma, string FileAFD)
        {
            AutomataFD = new AFD();
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();
            AutomataFD.LeerAFDdeArchivo(FileAFD, -1);
        }


        public AnalizadorLexico(string sigma, AFD AutFD)
        {
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();
            AutomataFD = AutFD;
        }

        public AnalizadorLexico(AFD AutFD)
        {
            AutomataFD = AutFD;
        }


        public ClassEstadoAnalizadorLexico GetEdoAnalizLexico()
        {
            ClassEstadoAnalizadorLexico EdoActualAnaliz = new ClassEstadoAnalizadorLexico();
            EdoActualAnaliz.CaracterActual = CaracterActual;
            EdoActualAnaliz.EdoActual = EdoActual;
            EdoActualAnaliz.EdoTransicion = EdoTransicion;
            EdoActualAnaliz.FinLexema = FinLexema;
            EdoActualAnaliz.IndiceCaracterActual = IndiceCaracterActual;
            EdoActualAnaliz.IniLexema = IniLexema;
            EdoActualAnaliz.Lexema = Lexema;
            EdoActualAnaliz.PasoPorEdoAcept = PasoPorEdoAcept;
            EdoActualAnaliz.token = token;
            EdoActualAnaliz.Pila = Pila;
            return EdoActualAnaliz;
        }

        public bool SetEdoAnalizLexico(ClassEstadoAnalizadorLexico e)
        {
            CaracterActual = e.CaracterActual;
            EdoActual = e.EdoActual;
            EdoTransicion = e.EdoTransicion;
            FinLexema = e.FinLexema;
            IndiceCaracterActual = e.IndiceCaracterActual;
            IniLexema = e.IniLexema;
            Lexema = e.Lexema;
            PasoPorEdoAcept = e.PasoPorEdoAcept;
            token = e.token;
            Pila = e.Pila;
            return true;
        }

        public void SetSigma(string sigma)
        {
            CadenaSigma = sigma;
            PasoPorEdoAcept = false;
            IniLexema = 0;
            FinLexema = -1;
            IndiceCaracterActual = 0;
            token = -1;
            Pila.Clear();
        }

        public string getLexema()
        {
            return this.Lexema;
        }

        public int getIndiceCaracterActual()
        {
            return this.IndiceCaracterActual;
        }


        public string CadenaXAnalizar()
        {
            return CadenaSigma.Substring(IndiceCaracterActual, CadenaSigma.Length - IndiceCaracterActual);
        }

        public int getEstadoActual()
        {
            return this.EdoActual;
        }

        public int getTamSigma()
        {
            return CadenaSigma.Length; 
        }


        public int getIniLexema()
        {
            return IniLexema;
        }

       public int getLongLexema()
        {
            return Lexema.Length;
        }


        public int yylex()
        {
            while (true)
            {
                Pila.Push(IndiceCaracterActual);
                if (IndiceCaracterActual >= CadenaSigma.Length)
                {
                    Lexema ="";
                    return SimbolosEspeciales.FIN;
                }
                IniLexema = IndiceCaracterActual;
                EdoActual = 0;
                PasoPorEdoAcept = false;
                FinLexema = -1;
                token = -1;
                while (IndiceCaracterActual < CadenaSigma.Length)
                {

                    CaracterActual = CadenaSigma[IndiceCaracterActual];
                    EdoTransicion = AutomataFD.TransicionesAFD[EdoActual][CaracterActual];
                    if (EdoTransicion != -1)
                    {
                        if (AutomataFD.TransicionesAFD[EdoTransicion][255] != -1)
                        {
                            PasoPorEdoAcept = true;
                            token = AutomataFD.TransicionesAFD[EdoTransicion][255];
                            FinLexema = IndiceCaracterActual;
                            //System.out.println("+"+IndiceCaracterActual + CadenaSigma.length()+ PasoPorEdoAcept);
                        }
                        IndiceCaracterActual++;
                        EdoActual = EdoTransicion;

                        continue;
                    }

                    break;
                }
                if (!PasoPorEdoAcept)
                {
                    IndiceCaracterActual = IniLexema + 1;

                    Lexema = CadenaSigma.Substring(IniLexema, 1);
                    token = SimbolosEspeciales.ERROR;
                    return token;
                }

                Lexema = CadenaSigma.Substring(IniLexema, FinLexema - IniLexema + 1);
                IndiceCaracterActual = FinLexema + 1;
                if (token == SimbolosEspeciales.OMITIR)
                    continue;
                else
                    return token;
            }

        }



        public bool UndoToken()
        {
            if (Pila.Count == 0)
                return false;
            IndiceCaracterActual = Pila.Pop();
            return true;
        }

        internal void SetSigma()
        {
            throw new NotImplementedException();
        }
    }
}
