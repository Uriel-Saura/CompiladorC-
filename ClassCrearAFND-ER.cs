using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class ClassCrearAFND_ER
    {

            public AnalizadorLexico L;
            public int idAFN;
            String Expresion;
            public AFND result;
            public List<AFND> afn1 = new List<AFND>();

        public ClassCrearAFND_ER(String sigma, AFD AutFD, int idER)
            {
                Expresion = sigma;
                L = new AnalizadorLexico(Expresion, AutFD);
                idAFN = idER;


            }


            public void SetER(String sigma)
            {
                Expresion = sigma;
                L.SetSigma(sigma);
            }

            public AFND IniEvalER()
            {

            int Token;
            AFND f = new AFND();

            if (E(f))
            {
                Token = L.yylex();
                if (Token == 0)
                {
                    result = f;
                    f.IdAFND = idAFN;
                    afn1.Add(f);
                    return f;
                }

            }
            return null;

        }

        public bool E(AFND f)
            { //
                if (T(f))
                {// Iden
                    if (Ep(f))
                    {//Eq (=)
                        return true;

                    }
                }
                return false;
            }

            public bool Ep(AFND f)
            {
                int Token;
                AFND f2 = new AFND();
                Token = L.yylex();

                if (Token == 10)
                {//or
                    if (T(f2))
                    {
                     //unimos los AFND
                     
                        f.UnirAFND(f2);
                        if (Ep(f))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                L.UndoToken();
                return true;
            }

            public bool T(AFND f)
            {
                if (C(f))
                {
                    if (Tp(f))
                    {
                        return true;
                    }
                }
                return false;
            }

            public bool Tp(AFND f)
            {
                int Token;
                AFND f2 = new AFND()
                ;
                Token = L.yylex();
                if (Token == 20)
                {//&
                    if (C(f2))
                    {
                        f.ConcAFND(f2);
                        if (Tp(f))
                        {
                            return true;
                        }
                    }
                    return false;
                }
                L.UndoToken();
                return true;
            }

            public bool C(AFND f)
            {
                if (F(f))
                {
                    if (Cp(f))
                    {
                        return true;
                    }
                }
                return false;
            }
            public bool Cp(AFND f)
            {
                int Token;
                Token = L.yylex();

                switch (Token)
                {
                    case 30:
                        f.CerrPos();
                        if (Cp(f))
                        {
                            return true;
                        }
                        return false;


                    case 40:
                        f.CerrKleen();
                        if (Cp(f))
                        {
                            return true;
                        }
                        return false;


                    case 50:
                        f.Opcional();
                        if (Cp(f))
                        {
                            return true;
                        }
                        return false;


                    default:
                        break;
                }
                /* 
                if(Token == 30 ||Token==40|| Token==50){//+ * ?
                    if(Cp()){
                        return true;
                    }
                    return false;
                }*/
                L.UndoToken();
                return true;
            }

            public bool F(AFND f)
            {
                int Token;
                String simbolo;
            char lexema, lexema2;
                Token = L.yylex();
                switch (Token)
                {
                    case 60: // 60=(   (E)
                        if (E(f))
                        {
                            return (L.yylex() == 70);

                            /* 
                            Token= L.yylex();
                            if(Token == 70){// )
                                return true;
                            }*/
                        }
                        return false;
                    case 80: // [

                        Token = L.yylex();

                    if (Token == 110)
                    {// CARACTER
                     // lexema = (L.Lexema.charAt(0) == '\\') ? L.Lexema.substring(1, 2) : L.Lexema.substring(0, 1);
                        lexema = (L.Lexema[0] == '\\') ? L.Lexema[1] : L.Lexema[0];
                        // lexema=L.Lexema;

                        Token = L.yylex();

                            if (Token == 100)
                            {// -
                                Token = L.yylex();
                                if (Token == 110)
                                {// CARACTER

                                    lexema2 = (L.Lexema[0] == '\\') ? L.Lexema[1] : L.Lexema[0];
                                    //lexema2=L.Lexema;
                                    Token = L.yylex();

                                    if (Token == 90)
                                    {// ]
                                     //f=new AFN();
                                        f.CrearAFNDBasico(lexema, lexema2, idAFN);
                                        return true;
                                    }
                                }
                            }
                        }

                        return false;
                    case 110: // CARACTER
                              //f=new AFN();
                        lexema = (L.Lexema[0] == '\\') ? L.Lexema[1] : L.Lexema[0];
                    //lexema=L.Lexema;

                    f.CrearAFNDBasico(lexema,idAFN);
                        return true;

                    default:
                        return false;
                }
            }

        }
    }
