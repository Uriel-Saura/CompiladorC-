using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{
    internal class DescensoRecusivoGramaticas
    {

        public AnalizadorLexico L;
        public string Expresion;
        public ClassElemArreglo[] ArrReglas = new ClassElemArreglo[100]; //arreglo de reglas
        public int NumReglas = 0; //contador de reglas    

        public HashSet<string> Vn = new HashSet<string>();
        public HashSet<string> Vt = new HashSet<string>();
        public List<string> LVn = new List<string>();
        public List<string> LVt = new List<string>();


        //gets
        public int getNumReglas()
        {
            return this.NumReglas;
        }

        public ClassElemArreglo getArrReglas(int i)
        {
            return this.ArrReglas[i];
        }

        public string getExpresion()
        {
            return this.Expresion;
        }

        public HashSet<string> getVn()
        {
            return this.Vn;
        }

        public HashSet<string> getVt()
        {
            return this.Vt;
        }

        public List<string> getLVn()
        {
            return this.LVn;
        }

        public List<string> getLVt()
        {
            return this.LVt;
        }

        



        public DescensoRecusivoGramaticas(string sigma, AFD AutFD)
        {
            Expresion = sigma;
            L = new AnalizadorLexico(Expresion, AutFD);
            Vn.Clear();
            Vt.Clear();
        }

        public DescensoRecusivoGramaticas(AFD AutFD)
        {
            L = new AnalizadorLexico(AutFD);
            Vn.Clear();
            Vt.Clear();
        }


        public bool SetGram(string sigma)
        {
            Expresion = sigma;
            L.SetSigma(sigma);
            return true;
        }

        public bool IniEvalGram()
        {

            int Token;

            if (G())
            {
                Token = L.yylex();
                if (Token == 0)
                {
                    IdentificarTerminales();
                    Vn.Add("$");
                    LVn.Add("$");
                    foreach(string t in Vt)
                    {
                        LVt.Add(t);
                    }
                    Vt.Add("$");
                    LVt.Add("$");
                    return true;
                }

            }
            return false;
        }

        public bool G()
        { //
            if (ListaReglas())
                return true;
            
            return false;
        }

        public bool ListaReglas()
        {
            int Token;
            if (Reglas())
            {// 
                Token = L.yylex();
                if (Token == 10)
                {//;
                    if (ListaReglasP())
                        return true;
                }
                return false;
            }
            return false;

        }


        public bool ListaReglasP()
        {
            ClassEstadoAnalizadorLexico edoAL;
            edoAL = L.GetEdoAnalizLexico();
            int Token;
            Token = L.yylex();
            if(Token == 50)
            {// /n -> saltot de linea
                if (Reglas())
                {
                    Token = L.yylex();
                    if (Token == 10)
                    {// ;
                        if (ListaReglasP())
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            L.SetEdoAnalizLexico(edoAL);
            return true;
        }

        public bool Reglas()
        {
            int Token;
            string simbolo = "";
            if (LadoI(ref simbolo))
            { //referencia
                Vn.Add(simbolo);
                LVn.Add(simbolo);
                Token = L.yylex();
                if (Token == 20)
                { // ->
                    if (LadosDerechos(simbolo))
                        return true;
                }
            }
            return false;
        }


        public bool LadoI(ref string simbolo)
        {
            int Token;
            Token = L.yylex();

            if (Token == 40)
            {//simbolo
                //simbolo.setSimbolo(L.Lexema);
                simbolo = L.Lexema;
                return true;
            }
            return false;
        }

        public bool LadosDerechos(string simbolo)
        {
            if (LadoDerecho(simbolo))
            {
                if (LadosDerechosP(simbolo))
                {
                    return true;
                }
            }
            return false;
        }

        public bool LadosDerechosP(string simbolo)
        {
            int Token;
            Token = L.yylex();

            if (Token == 30)
            {//or
                if (LadoDerecho(simbolo))
                {
                    if (LadosDerechosP(simbolo))
                    {
                        return true;
                    }
                }
                return false;
            }
            L.UndoToken();
            return true;
        }

        public bool LadoDerecho(string sim)
        {
            List<Nodo> Lis = new List<Nodo>();
            Lis.Clear();
            if (SecSimbolos(ref Lis))
            {
                ArrReglas[NumReglas] = new ClassElemArreglo();
                ArrReglas[NumReglas].setInfSimbolo(new Nodo(sim, false)); //el false es para indicar que no es terminal 
                ArrReglas[NumReglas++].setLisD(Lis);
                return true;

            }
            return false;
        }

        public bool SecSimbolos(ref List<Nodo> lis)
        {//SecSimbolos(ref Lista<Nodo> Lista)
            int Token;
            Nodo N;
            Token = L.yylex();
            if (Token == 40)
            {//simbolo
                N = new Nodo(L.Lexema, false);
                if (SecSimbolosP(ref lis))
                {//SecSimbolosP(ref lista)
                    //lis.Add(0, N); //agregar el nodo al inicio
                    //lis[0] = N;
                    lis.Insert(0, N);
                    return true;
                }
            }
            return false;
        }

        public bool SecSimbolosP(ref List<Nodo> lis)
        {//List<Nodo> Lista){ //se manda por referencia la lista
            int Token;
            Nodo N;
            Token = L.yylex();
            if(Token == 60)
            {//  " "
                Token = L.yylex();
                if (Token == 40)
                {// simbolo
                    N = new Nodo(L.Lexema, false);
                    if (SecSimbolosP(ref lis))
                    {//SecSimbolosP(ref Lista)){ //se manda por referencvia la lista
                     //lis.Add(0, N);
                        lis.Insert(0, N);
                        return true;
                    }
                   
                }
                return false;
            }
            L.UndoToken();
            return true;
        }

        public void IdentificarTerminales()
        {
            string eps = "epsilon";
            int i;
            for (i = 0; i < NumReglas; i++)
            {
                foreach(Nodo N in ArrReglas[i].getListD())
                {
                    if (!Vn.Contains(N.getCadena()) && !N.getCadena().Equals(eps))
                    {
                        N.setTNT(true);
                        Vt.Add(N.getCadena());
                    }
                }
            }
        }


        public HashSet<string> First(List<Nodo> l)
        {
            int i, j;
            Nodo N;
            HashSet<string> R = new HashSet<string>();
            R.Clear();
            if (l.Count() == 0)
                return R;

            for (j = 0; j < l.Count(); j++)
            {
                N = l[j];
                if (N.getTNT() || N.getCadena().Equals("epsilon"))
                {
                    R.Add(N.getCadena());
                    return R;
                }

                //N es no terminal. Se calcula el first de cada lado derecho de este no terminal 

                for (i = 0; i < NumReglas; i++)
                {
                    if (ArrReglas[i].getListD()[0].getCadena() == N.getCadena())
                        continue;
                    if (ArrReglas[i].getNodo().getCadena().Equals(N.getCadena()))
                        R.UnionWith(First( ArrReglas[i].getListD() ));
                }

                if (R.Contains("epsilon"))
                {
                    if (j == (l.Count() - 1))
                        continue;
                    R.Remove("epsilon");
                }
                else
                    break;
            }
            return R;
        }
       
        public HashSet<string> Follow(string SimbNoTerm)
        {
            HashSet<string> R = new HashSet<string>();
            HashSet<string> Aux = new HashSet<string>();
            List<Nodo> ListaPost = new List<Nodo>();
            R.Clear();
            int i, j, k;

            if (ArrReglas[0].getNodo().getCadena().Equals(SimbNoTerm))
                R.Add("$");
            for (i = 0; i < NumReglas; i++)
            { //se busca SimbNoTerm en los lados derechos de todo
                for (j = 0; j < ArrReglas[i].getListD().Count(); j++)
                { //se recorre la lista del lado derecho buscando al simbolo SimbNoterm
                    if (ArrReglas[i].getListD()[j].getCadena().Equals(SimbNoTerm))
                    {
                        ListaPost.Clear();
                        for (k = j + 1; k < ArrReglas[i].getListD().Count(); k++) //Obtenemos la lista que corresponde a los simnolos que estan despues 
                            ListaPost.Add(ArrReglas[i].getListD()[k]);
                        //Si no hay mas simbolos despues de SimbNoTerm se calcula el follow

                        if (ListaPost.Count() == 0)
                        {
                            //Si el simbolo del lado izquierdo es igual al simbolo del que 
                            //el follow, omitimos la regla
                            if (!ArrReglas[i].getNodo().getCadena().Equals(SimbNoTerm))
                                R.UnionWith(Follow(ArrReglas[i].getNodo().getCadena()));
                            break;

                        }

                        //se calcula el First de la lista l que esta despues del elemento j

                        Aux.Clear();
                        Aux = First(ListaPost);
                        if (Aux.Contains("epsilon"))
                        {
                            Aux.Remove("epsilon");
                            R.UnionWith(Aux);
                            if (!ArrReglas[i].getNodo().getCadena().Equals(SimbNoTerm))
                                R.UnionWith(Follow(ArrReglas[i].getNodo().getCadena()));
                        }
                        else
                            R.UnionWith(Aux);

                    }
                }
            }
            return R;
        }







    }
}
