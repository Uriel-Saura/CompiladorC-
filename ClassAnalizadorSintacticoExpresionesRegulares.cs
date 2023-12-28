using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class ClassAnalizadorSintacticoExpresionesRegulares
    {

        string Expresion;
        public AnalizadorLexico L;


        public ClassAnalizadorSintacticoExpresionesRegulares(String sigma, AFD AutFD)
            {
                Expresion = sigma;
                L = new AnalizadorLexico(Expresion, AutFD);

            }


            public void SetExpresionR(String sigma)
            {
                Expresion = sigma;
                L.SetSigma(sigma);
            }

            public bool IniEvalER()
            {

                int Token;

                if (E())
                {
                    Token = L.yylex();
                    if (Token == 0)
                    {
                        return true;
                    }

                }
                return false;
            }

            public bool E()
            { //
                if (T())
                {// Iden
                    if (Ep())
                    {//Eq (=)
                        return true;

                    }
                }
                return false;
            }

            public bool Ep()
            {
                int Token;
                Token = L.yylex();

                if (Token == 10)
                {//or
                    if (T())
                    {
                        if (Ep())
                        {
                            return true;
                        }
                    }
                    return false;
                }
                L.UndoToken();
                return true;
            }

            public bool T()
            {
                if (C())
                {
                    if (Tp())
                    {
                        return true;
                    }
                }
                return false;
            }

            public bool Tp()
            {
                int Token;
                Token = L.yylex();
                if (Token == 20)
                {//&
                    if (C())
                    {
                        if (Tp())
                        {
                            return true;
                        }
                    }
                    return false;
                }
                L.UndoToken();
                return true;
            }

            public bool C()
            {
                if (F())
                {
                    if (Cp())
                    {
                        return true;
                    }
                }
                return false;
            }
            public bool Cp()
            {
                int Token;
                Token = L.yylex();

                if (Token == 30 || Token == 40 || Token == 50)
                {//+ * ?
                    if (Cp())
                    {
                        return true;
                    }
                    return false;
                }
                L.UndoToken();
                return true;
            }

            public bool F()
            {
                int Token;
                Token = L.yylex();
                switch (Token)
                {
                    case 60: // 60=(   (E)
                        if (E())
                        {
                            Token = L.yylex();
                            if (Token == 70)
                            {// )
                                return true;
                            }
                        }
                        return false;
                    case 80: // [

                        Token = L.yylex();
                        if (Token == 110)
                        {// CARACTER
                            Token = L.yylex();
                            if (Token == 100)
                            {// -
                                Token = L.yylex();
                                if (Token == 110)
                                {// CARACTER
                                    Token = L.yylex();
                                    if (Token == 90)
                                    {// ]

                                        return true;
                                    }
                                }
                            }
                        }

                        return false;
                    case 110: // CARACTER

                        return true;
                    default:
                        return false;
                }
            }




    }
}
