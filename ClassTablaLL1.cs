using DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle;
using DocumentFormat.OpenXml.VariantTypes;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QuickGraph;
using QuickGraph.Algorithms;
using QuickGraph.Collections;
using QuickGraph.Graphviz;
using static Practica1.Forms.FormDescensoRecursivoGramatica;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using QuickGraph.Graphviz.Dot;
using DocumentFormat.OpenXml.Drawing;
using System.ComponentModel;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz;
using System.Threading;

namespace Practica1
{
    internal class ClassTablaLL1
    {

        public static List<ClassTablaLL1> ConjDeLL1 = new List<ClassTablaLL1>();
        public string[][] TabLL1;
        public int idTLL;
        public int row1;
        public int column1;
        public List<string> indexT = new List<string>();
        public List<int> indexlex = new List<int>();
        DescensoRecusivoGramaticas a;
        AnalizadorLexico L;
        public List<string> pila;
        int tamanioSigma = 0;
        private static HashSet<string> visited;
        Stack<nodoArbol> PilaArbol = new Stack<nodoArbol>();

        public List<string> TabAnLL1 = new List<string>();

        List<string> modiSigma = new List<string>();

        public ClassTablaLL1(DescensoRecusivoGramaticas a)
        {
            this.a = a;
            TabLL1 = new string[a.getLVn().Count][];
            row1 = a.LVn.Count;
            column1 = a.LVt.Count + 1;
            indexT = a.LVt;
            this.a = a;

            for (int i = 0; i < row1; i++)
            {
                TabLL1[i] = new string[column1];
                for (int j = 0; j < column1; j++)
                {
                    if (j == 0)
                    {
                        TabLL1[i][j] = a.LVn[i];
                    }
                    else
                    {
                        TabLL1[i][j] = "-1";
                    }
                }
            }


        }


        public ClassTablaLL1(string[][] Tablall1, List<int> newtoken, List<string> terminales, DescensoRecusivoGramaticas aux)
        {
            TabLL1 = Tablall1;
            indexlex = newtoken;
            indexT = terminales;
            //agregamos el 0 en el indelex
            indexlex.Add(0);
            a = aux;
        }

        public void impTabLL1()
        {
            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column1; j++)
                {
                    Console.Write(TabLL1[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        public string[][] getTabLL1()
        {
            return TabLL1;
        }
        public void llenarTabla()
        {
            for (int j = 0; j < a.NumReglas; j++)
            {
                foreach (string st in a.First(a.ArrReglas[j].getListD()))
                {
                    if (st.Equals("epsilon"))
                    {

                        foreach (string st2 in a.Follow(a.ArrReglas[j].getNodo().getCadena()))
                        {
                            int xi2 = indexT.IndexOf(st2);
                            if (xi2 != -1)
                            {
                                int ij2 = a.LVn.IndexOf(a.ArrReglas[j].getNodo().getCadena());
                                if (ij2 != -1)
                                {
                                    //TabLL1[ij2][xi2 + 1] = string.valueOf(j + 1);
                                    TabLL1[ij2][xi2 + 1] = (j+1).ToString();
                                }
                            }

                        }
                    }
                    int xi = indexT.IndexOf(st);
                    if (xi != -1)
                    {
                        int ij = a.LVn.IndexOf(a.ArrReglas[j].getNodo().getCadena());
                        if (ij != -1)
                        {
                            //TabLL1[ij][xi + 1] = string.valueOf(j + 1);
                            TabLL1[ij][xi + 1] = (j + 1).ToString();

                        }
                    }
                }
            }
        }



        public bool AnalizarSin(AFD afd, string sigma, DataGridView dataGridView, DescensoRecusivoGramaticas aux)
        {
            int i = 0;
            L = new AnalizadorLexico(sigma, afd);
            Stack<Nodo> Pila = new Stack<Nodo>();
            int token;
            int indiceX;
            int indiceY;
            int regla = 0;
            string Spila = "";
            string Sregla = "";
            Stack<nodoArbol> PilaArbol = new Stack<nodoArbol>();
            a = aux;

            TabAnLL1.Clear();

            Pila.Push(this.a.ArrReglas[0].getNodo());
            nodoArbol raiz = new nodoArbol(0, this.a.ArrReglas[0].getNodo().getCadena(), false, 0);
            Arbol newArbol = new Arbol(raiz);
            nodoArbol auxNA;
            PilaArbol.Push(raiz);

            token = L.yylex();

            while (Pila.Count != 0)
            {
                modiSigma.Add(sigma.Substring(i));
                indiceX = indexlex.IndexOf(token);
                if (!Pila.Peek().getTNT())
                {
                    indiceY = a.LVn.IndexOf(Pila.Peek().getCadena());
                    if (TabLL1[indiceY][indiceX + 1] != "-1")
                    {
                        regla = int.Parse(TabLL1[indiceY][indiceX + 1]);

                        Spila = "$";
                        for (int k = 0; k < Pila.Count; k++)
                        {
                            Spila = Spila + " " + Pila.ElementAt(k).getCadena();
                        }
                        Sregla = "R " + regla.ToString() + "," + a.ArrReglas[regla - 1].getNodo().getCadena() + "->";
                        for (int w = 0; w < a.ArrReglas[regla - 1].getListD().Count; w++)
                        {
                            Sregla = Sregla + " " + a.ArrReglas[regla - 1].getListD()[w].getCadena();
                        }

                        TabAnLL1.Add(Spila);
                        int tam = L.getIniLexema();
                        int longitudLexema = Math.Min(sigma.Length - tam, L.getLongLexema());
                        TabAnLL1.Add(sigma.Substring(tam, longitudLexema) + "$");
                        //agregamos a la tabla una subcadena de sigma
                        TabAnLL1.Add(Sregla);

                        Pila.Pop();
                        auxNA = PilaArbol.Pop();

                        if (a.ArrReglas[regla - 1].getListD()[0].getCadena() != "epsilon")
                        {
                            for (int j = 0; j < a.ArrReglas[regla - 1].getListD().Count; j++)
                            {
                                Pila.Push(a.ArrReglas[regla - 1].getListD()[a.ArrReglas[regla - 1].getListD().Count - 1 - j]);
                                PilaArbol.Push(newArbol.AgregarNodo(a.ArrReglas[regla - 1].getListD()[a.ArrReglas[regla - 1].getListD().Count - 1 - j].getCadena(), auxNA.getNivel() + 1));
                                auxNA.InsertarHijo(PilaArbol.Peek());
                            }
                        }
                        else
                        {
                            auxNA.InsertarHijo(newArbol.AgregarNodo(a.ArrReglas[regla - 1].getListD()[0].getCadena(), auxNA.getNivel() + 1));
                            auxNA.getHijos()[auxNA.getHijos().Count - 1].setHoja(true);
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else //terminales
                {
                    if (Pila.Peek().getCadena().Equals(indexT[indexlex.IndexOf(token)]))
                    {
                        Spila = "$";
                        for (int k = 0; k < Pila.Count; k++)
                        {
                            Spila = Spila + " " + Pila.ElementAt(k).getCadena();
                        }
                        Sregla = "POP ";

                        TabAnLL1.Add(Spila);
                        i++;

                        TabAnLL1.Add(sigma.Substring(L.getLexema().Length + tamanioSigma) + "$");
                        TabAnLL1.Add(Sregla);
                        tamanioSigma = tamanioSigma + L.getLexema().Length;

                        Pila.Pop();
                        auxNA = PilaArbol.Pop();
                        auxNA.setHoja(true);
                        auxNA.setCadena(L.getLexema());
                        token = L.yylex();

                    }
                    else
                    {
                        return false;
                    }
                }
            }

            if (token == 0 && Pila.Count == 0)
            {
                // Agregar la TabAnLL1 al DataGridView
                for (int k = 0; k < TabAnLL1.Count; k = k + 3)
                {
                    dataGridView.Rows.Add(TabAnLL1[k], TabAnLL1[k + 1], TabAnLL1[k + 2]);
                }

                // Modificar la tercera columna del DataGridView con la lista de acciones
                for (int k = 0; k < modiSigma.Count; k++)
                {
                    dataGridView.Rows[k].Cells[1].Value = modiSigma[k];
                }

                ImprimirArbolGraficamente(newArbol);

                MessageBox.Show("Arbol creado graficamente");

                return true;
            }

            return false;
        }

        private void ImprimirArbolGraficamente(Arbol arbol)
        {
            BidirectionalGraph<string, Edge<string>> graph = new BidirectionalGraph<string, Edge<string>>();

            // Llamada a la función recursiva para agregar los nodos y las conexiones al grafo
            AgregarNodoAGrafo(arbol.raiz, graph);

            string dotFilePath = @"C:\Users\josec\source\repos\Practica1\bin\Debug\AFNDS\arbol.dot";
            string imageFilePath = @"C:\Users\josec\source\repos\Practica1\bin\Debug\AFNDS\arbol.png";

            // Guardar el grafo en un archivo DOT
            GraphvizAlgorithm<string, Edge<string>> graphviz = new GraphvizAlgorithm<string, Edge<string>>(graph);
            graphviz.FormatVertex += (sender, args) => args.VertexFormatter.Label = args.Vertex;
            graphviz.Generate(new FileDotEngine(), dotFilePath);

            // Utilizar la herramienta "dot" de Graphviz para generar la imagen a partir del archivo DOT
            ProcessStartInfo startInfo = new ProcessStartInfo("dot", $"-Tpng -o{imageFilePath} {dotFilePath}");
            Process.Start(startInfo);
            //esperamos
            Thread.Sleep(1000);
            // Abrir la imagen
            Process.Start(imageFilePath);
        }


        private void AgregarNodoAGrafo(nodoArbol nodo, BidirectionalGraph<string, Edge<string>> graph)
        {
            string nodoId = $"[{nodo.getCadena()}, {nodo.id}]"; // Agregar el no terminal y el terminal al ID del nodo

            if (nodo.hoja)
                graph.AddVertex(nodoId); // Agregar nodo hoja al grafo
            else
            {
                for (int i = 0; i < nodo.Hijos.Count; i++)
                {
                    nodoArbol hijo = nodo.Hijos[i];
                    string hijoId = $"[{hijo.getCadena()}, {hijo.id}]"; // Agregar el no terminal y el terminal al ID del hijo
                    graph.AddVerticesAndEdge(new Edge<string>(nodoId, hijoId)); // Agregar conexión entre nodo padre e hijo

                    AgregarNodoAGrafo(hijo, graph); // Llamada recursiva para agregar los hijos del hijo
                    // Si el nodo tiene más de un hijo, crear un nodo intermedio para mantener una sola conexión saliente
                    if (nodo.Hijos.Count > 1 && i < nodo.Hijos.Count - 1)
                    {
                        string intermedioId = $"[{nodo.getCadena()}-{nodo.id}]"; // Agregar un ID para el nodo intermedio
                        graph.AddVertex(intermedioId); // Agregar el nodo intermedio al grafo
                        graph.AddVerticesAndEdge(new Edge<string>(nodoId, intermedioId)); // Agregar conexión entre nodo padre y nodo intermedio
                        nodoId = intermedioId; // Establecer el ID del nodo intermedio como el nuevo nodo padre para la siguiente iteración
                    }
                }
            }
        }



        private class FileDotEngine : IDotEngine
        {
            public string Run(GraphvizImageType imageType, string dot, string outputFileName)
            {
                System.IO.File.WriteAllText(outputFileName, dot);
                return outputFileName;
            }
        }











        public static void DFS(BidirectionalGraph<string, Edge<string>> graph, string vertex)
        {
            Console.WriteLine(vertex); // Imprimir el nodo actual

            // Obtener los vecinos del nodo actual
            var neighbors = graph.OutEdges(vertex).Select(e => e.Target);

            // Aplicar DFS a los vecinos no visitados
            foreach (var neighbor in neighbors)
            {
                if (!visited.Contains(neighbor))
                {
                    visited.Add(neighbor);
                    DFS(graph, neighbor);
                }
            }
        }

        public static void DFSWithSigma(BidirectionalGraph<string, Edge<string>> graph, string vertex, string sigma)
        {
            Console.WriteLine(vertex); // Imprimir el nodo actual

            // Obtener los vecinos del nodo actual
            var neighbors = graph.OutEdges(vertex).Select(e => e.Target);

            // Verificar si la cadena sigma está vacía
            if (string.IsNullOrEmpty(sigma))
                return;

            // Obtener el siguiente símbolo de la cadena sigma
            char nextSymbol = sigma[0];
            string remainingSigma = sigma.Substring(1);

            // Verificar si el siguiente símbolo coincide con alguno de los vecinos
            foreach (var neighbor in neighbors)
            {
                if (neighbor == nextSymbol.ToString())
                {
                    if (!visited.Contains(neighbor))
                    {
                        visited.Add(neighbor);
                        DFSWithSigma(graph, neighbor, remainingSigma);
                    }
                }
            }
        }

        private string GetStackString(Stack<Nodo> stack)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Nodo nodo in stack.Reverse())
            {
                sb.Append(nodo.getCadena());
            }
            return sb.ToString();
        }




    }
}
         