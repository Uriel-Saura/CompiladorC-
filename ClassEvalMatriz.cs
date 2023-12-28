using DocumentFormat.OpenXml.Office.MetaAttributes;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Presentation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1
{

    internal class ClassEvalMatriz
    {
        string Expresion;
        public AnalizadorLexico L;
        //int[,] Matriz;
        List<List<int>> Matriz = new List<List<int>>();
        List<int> Filas = new List<int>();
        Dictionary< char, List<List<int>> > HashMat = new Dictionary<char, List<List<int>>> ();
        List<List<List<int>>> ListaMatrices = new List<List<List<int>>>(); //lista de matrices
        List<string> operaciones  = new List<string> ();
        char auxIDENT;
        private  int fila = 0;
        private int columna = 0; 
        private string operation;

        public ClassEvalMatriz(string sigma, string FileAFD, int IdentifAFD)
        {
            Expresion = sigma;
            L = new AnalizadorLexico(Expresion, FileAFD, IdentifAFD);
        }

        public ClassEvalMatriz(string sigma, AFD Automata)
        {
            Expresion = sigma;
            L = new AnalizadorLexico(Expresion, Automata);
            fila = 0;
            columna = 0;
            operation = "";
        }

        public void SetExpresion(string sigma)
        {
            Expresion = sigma;
            L.SetSigma(sigma);
        }

        public Dictionary<char,List<List<int>>> getMAT()
        {
            //imprimimos la matriz
            Console.WriteLine("MATRIZ ANTES DE RETORNAR:");
            ImprimirMatriz(Matriz);


            //agregamos la matriz a la lista de matrices
            HashMat.Add(auxIDENT, Matriz);
            return HashMat;

        }

        //metodos
        public bool IniEvalMatrices()
        {
            int Token;
            if (Asig())
            {
                Token = L.yylex();
                if (Token == 0)
                    return true;
            }
            return false;
        }

        public bool Asig()
        {
            int Token;
            Token = L.yylex();
            auxIDENT = L.getLexema()[0];
            if (Token == 120) //IDENT
            {
                Token = L.yylex();
                if (Token == 10)//EQ
                {
                    if (E())
                    {
                        Token = L.yylex();
                        if (Token == 20)
                        {//PC
                            //agregamos la matriz a la lista de matrices
                            ListaMatrices.Add(Matriz);
                            //imprimimos el tamaño de ListaMatrices
                            Console.WriteLine("Tamaño de ListaMatrices: " + ListaMatrices.Count);
                            //imprimimos las matrices de la lista de matrices
                            foreach (List<List<int>> matriz in ListaMatrices)
                            {
                                foreach (List<int> fila in matriz)
                                {
                                    foreach (int elemento in fila)
                                    {
                                        Console.Write(elemento + " ");
                                    }
                                    Console.WriteLine();
                                }
                                Console.WriteLine();
                            }
                            //verificamos si hay operacion
                            if(operaciones.Count() != 0)
                            {
                                //limpiamos la matriz
                                Matriz = new List<List<int>>();


                                if (operaciones[0].Equals("+"))
                                {
                                    // Suma de matrices
                                    Matriz = SumarMatrices(ListaMatrices[0], ListaMatrices[1]);
                                    Console.WriteLine("Suma de matrices:");
                                    ImprimirMatriz(Matriz);

                                }
                                else if (operaciones[0].Equals("-"))
                                {
                                    // Resta de matrices
                                    Matriz = RestarMatrices(ListaMatrices[0], ListaMatrices[1]);
                                    Console.WriteLine("Resta de matrices:");
                                    ImprimirMatriz(Matriz);
                                }
                                else if(operaciones[0].Equals("*"))
                                {
                                    // Multiplicación de matrices
                                    Matriz = MultiplicarMatrices(ListaMatrices[0], ListaMatrices[1]);
                                    Console.WriteLine("Multiplicación de matrices:");
                                    ImprimirMatriz(Matriz);
                                    //remplazamos la matriz que fue agregada al hashmap



                                }
                                else
                                {
                                    Console.WriteLine("Operacion no valida");
                                }
                            }

                            return true;
                        }
                    }

                }
            }
            return false;
        }
        public bool E()
        {
            if (T())
                if (Ep())
                    return true;
            return false;
        }

        public bool Ep()
        {
            int Token;
            Token = L.yylex();
            
            if (Token == 30 || Token == 40) //mas o menos
            {
                operaciones.Add(L.getLexema());
                //CHECA SI ES + O -
                //agregamos la primera matriz a la lista de matries
                ListaMatrices.Add(Matriz);
                Matriz = new List<List<int>>();
                if (T())
                {
                    if (Ep())
                    {
                        return true;
                    }
                    return false;
                }
            }
            L.UndoToken();
            return true;
        }
        public bool T()
        {
            if (F())
                if (Tp())
                    return true;
            return false;
        }
        public bool Tp()
        {
            int Token;
            Token = L.yylex();
           
            if (Token == 50) //PROD
            {
                operaciones.Add(L.getLexema());
                if (F())
                    if (Tp())
                        return true;
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
                case 60: // PAR_I
                    if (E())
                    {
                        Token = L.yylex();
                        if (Token == 70)//par_d
                            return true;
                    }
                    return false;
                case 120://IDENT
                    return true;
                case 80: // CORCH_IZ
                    if (Renglones())
                    {
                        Token = L.yylex();
                        if (Token == 90)//CORCHETE_D
                            return true;
                    }
                    return false;

            }
            return false;
        }

        public bool Renglones()
        {
            if (Renglon())
                if (Renglonesp())
                    return true;
            return false;
        }
        public bool Renglonesp()
        {
            ClassEstadoAnalizadorLexico EdoAnalizadorLexico = new ClassEstadoAnalizadorLexico();
            EdoAnalizadorLexico = L.GetEdoAnalizLexico();

            if (Renglon())
            {
                if (Renglonesp())
                    return true;
                return false;
            }
            L.SetEdoAnalizLexico(EdoAnalizadorLexico);
            return true;
        }
        public bool Renglon()
        {
            int Token;
            Token = L.yylex();

            if (Token == 80) // CORCH_I
            {
                if (ListaNumeros())
                {
                    Token = L.yylex();
                    if (Token == 90)
                    { //CORCH_D
                        //  this.fila++;
                        Matriz.Add(Filas);
                        Filas = new List<int>();
                        //this.columna = 0;
                        return true;
                    }
                }
            }
            return false;
        }
        public bool ListaNumeros()
        {
            int Token;
            //guardamos el numero en la matriz
            Token = L.yylex();
            int numero = int.Parse(L.getLexema());
            if (Token == 110) //NUM
            {
                //Matriz[fila, columna] = numero;
                Filas.Add(numero);
                //this.columna++;
                if (ListaNumerosp())
                {
                    return true;
                }
            }

            return false;
        }
        public bool ListaNumerosp()
        {
            int Token;
            Token = L.yylex();
            if (Token == 100) //COMA
            {
                Token = L.yylex();
                int numero = int.Parse(L.getLexema());
                if (Token == 110){
                    this.columna++;
                    Filas.Add(numero);
                    // NUM
                    if (ListaNumerosp())
                        return true;
            }
                return false;

            }
            L.UndoToken();
            return true;
        }


        public static List<List<int>> SumarMatrices(List<List<int>> matriz1, List<List<int>> matriz2)
        {
            List<List<int>> resultado = new List<List<int>>();

            for (int i = 0; i < matriz1.Count; i++)
            {
                List<int> filaResultado = new List<int>();

                for (int j = 0; j < matriz1[i].Count; j++)
                {
                    int suma = matriz1[i][j] + matriz2[i][j];
                    filaResultado.Add(suma);
                }

                resultado.Add(filaResultado);
            }

            return resultado;
        }

        public static List<List<int>> RestarMatrices(List<List<int>> matriz1, List<List<int>> matriz2)
        {
            List<List<int>> resultado = new List<List<int>>();

            for (int i = 0; i < matriz1.Count; i++)
            {
                List<int> filaResultado = new List<int>();

                for (int j = 0; j < matriz1[i].Count; j++)
                {
                    int resta = matriz1[i][j] - matriz2[i][j];
                    filaResultado.Add(resta);
                }

                resultado.Add(filaResultado);
            }

            return resultado;
        }

        public static List<List<int>> MultiplicarMatrices(List<List<int>> matriz1, List<List<int>> matriz2)
        {
            List<List<int>> resultado = new List<List<int>>();

            for (int i = 0; i < matriz1.Count; i++)
            {
                List<int> filaResultado = new List<int>();

                for (int j = 0; j < matriz2[0].Count; j++)
                {
                    int producto = 0;

                    for (int k = 0; k < matriz1[i].Count; k++)
                    {
                        producto += matriz1[i][k] * matriz2[k][j];
                    }

                    filaResultado.Add(producto);
                }

                resultado.Add(filaResultado);
            }

            return resultado;
        }

        public static void ImprimirMatriz(List<List<int>> matriz)
        {
            for (int i = 0; i < matriz.Count; i++)
            {
                for (int j = 0; j < matriz[i].Count; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

    }
}

//A=[[1,2][3,4]];