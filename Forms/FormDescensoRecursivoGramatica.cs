using DocumentFormat.OpenXml.EMMA;
using QuickGraph.Algorithms.Search;
using QuickGraph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using QuickGraph;
using QuickGraph.Graphviz;
using QuickGraph.Graphviz.Dot;



namespace Practica1.Forms
{
    public partial class FormDescensoRecursivoGramatica : Form
    {
        public static int i = 0;
        private string archivo;
        //lista de no terminales
        public static List<string> noTerminales = new List<string>();
        //lista de terminales
        public static List<string> terminales = new List<string>();

        //creamos una lista de afds
        public static List<AFD> ListAFD = new List<AFD>();
        public static List<int>NewTokens = new List<int>();
        public static string[][] TablaLL1;
        public static Stack<string> Pila;
        DescensoRecusivoGramaticas aux;


        public FormDescensoRecursivoGramatica(List<AFD> AFD)
        {
            InitializeComponent();
            ListAFD = AFD;
            btnSUBIR_ARCHIVO.Enabled = false;
            btnSelect.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //no hace nada
        }

        private void btnConcat_AFND_Click(object sender, EventArgs e)
        {
            //recuperamos la opcion del dropdown
            int opcion = (int)this.listaAFD.SelectedItem;
            //BUSCAMOS EL AFD CON ID opcion
            AFD afd = ListAFD.Find(x => x.idAFD == opcion);


            //CREAR LL1
            //recuperamos los datos de la gramatica en un solo string
            string gramatica = textGramatica.Text;
            //limpiamos la cadena de los retornos de carro
            gramatica = gramatica.Replace("\r", "");
            
            //Mostramos la gramatica
            MessageBox.Show("La gramatica es: " + gramatica);
            Console.WriteLine("La gramatica es: " + gramatica);
            //quitamos los espacios al string
            //string[] gramatica = textGramatica.Text.Split('\n');
            //creamos un descenso recursivo
            DescensoRecusivoGramaticas a = new DescensoRecusivoGramaticas(gramatica, afd);
            //hacemos el descenso
            bool resultado = a.IniEvalGram();
            //mostrmaos el resultado
            MessageBox.Show("El valor del resultado es : " + resultado);
           //recuperamos los no terminales y terminales
            noTerminales = a.getLVn();
            terminales = a.getLVt();
           
            //imprimimos en la terminal la lista
            
            
            Console.WriteLine("Los no terminales son: ");
            foreach (string noTerminal in noTerminales)
            {
                Console.WriteLine(noTerminal);
            }
            Console.WriteLine("Los terminales son: ");
            foreach (string terminal in terminales)
            {
                Console.WriteLine(terminal);
            }
            //lo mostramos en un MessageBox
            MessageBox.Show("Los no terminales son: " + string.Join(",", noTerminales));
            MessageBox.Show("Los terminales son: " + string.Join(",", terminales));

            //insertamos los datos al datagridview en la columna No Terminales
            foreach (string noTerminal in noTerminales)
            {
                listaNoTerminal.Rows.Add(noTerminal);
            }
            //insertamos los datos al datagridview en la columna Terminales
            foreach (string terminal in terminales)
            {
                listaTerminales.Rows.Add(terminal);
            }




            aux = a;
            //creamos una tabla LL1
            ClassTablaLL1 b = new ClassTablaLL1(a);
            //llenamos la tabla LL1
            b.llenarTabla();

            TablaLL1 = b.getTabLL1();
            //creamos el datagridview del tamaño de la tablall1
            dataTablaLL1.ColumnCount = TablaLL1[0].Length;
            dataTablaLL1.RowCount = TablaLL1.Length;
            //imprimimos la tabla LL1 en el datagridview
            for (int i = 0; i < TablaLL1.Length; i++)
            {
                for (int j = 0; j < TablaLL1[i].Length; j++)
                {
                    dataTablaLL1.Rows[i].Cells[j].Value = TablaLL1[i][j];
                }
            }
            //agregamos una fila al inicio del data e imprimimos la lista de no terminales en la primera fila
            dataTablaLL1.Rows.Insert(0);
            for (int i = 0; i < terminales.Count; i++)
            {
                dataTablaLL1.Rows[0].Cells[i + 1].Value = terminales[i];
            }

            //ponemos en la fila 0 columna 0 el titulo "No terminal"
            dataTablaLL1.Rows[0].Cells[0].Value = "No terminal";

            //imprimimos la Tablall1 en la terminal
            Console.WriteLine("La tabla LL1 es: ");
            for (int i = 0; i < TablaLL1.Length; i++)
            {
                for (int j = 0; j < TablaLL1[i].Length; j++)
                {
                    Console.Write(TablaLL1[i][j] + " ");
                }
                Console.WriteLine();
            }



        }

        private void FormDescensoRecursivoGramatica_Load(object sender, EventArgs e)
        {
            //no hace nada
            if (ListAFD.Count == 0)
            {
                MessageBox.Show("No hay automatas para probar, importe un archivo o cree uno con las operaciónes");
                btnSelect.Enabled = true;
                i++;
            }
            else
            {
                //Mostramos los AFND en los comboBox
                foreach (AFD afnd in ListAFD)
                {
                    listaAFD.Items.Add(afnd.idAFD);
                }

            }

            //añadimos una cadena predeterminada al textbox
            textGramatica.Text = "E->T Ep;\r\nEp->or T Ep|epsilon;\r\nT->C Tp;\r\nTp->conc C Tp|epsilon;\r\nC->F Cp;\r\nCp->CerrPos Cp|CerrK Cp|Opc Cp|epsilon;\r\nF->Parizq E ParDer|simb|CorchIz simb guion simb CorchDer;";
            //textGramatica.Text = "ASIG->IDENT igual E pc;\r\nE->T Ep;\r\nEp->mas T Ep|menos T Ep|epsilon;\r\nT->F Tp;\r\nTp->por F Tp|epsilon;\r\nF->parIz E parDer|IDENT|matriz;\r\nmatriz->corIz renglones corDer;\r\nrenglones->renglon renglonesp;\r\nrenglonesp->renglon renglonesp|epsilon;\r\nrenglon->corIz listaNumeros corDer;\r\nlistaNumeros->numero listaNumerosp;\r\nlistaNumerosp->coma numero listaNumerosp|epsilon;";
        }

        private void btnSUBIR_ARCHIVO_Click(object sender, EventArgs e)
        {


            // Ruta: C:\Users\josec\source\repos\Practica1\bin\Debug
            string[][] matriz;

            // Lee el archivo línea por línea
            string[] lineas = File.ReadAllLines(archivo);

            // Crea la matriz a partir de las líneas del archivo
            matriz = new string[lineas.Length][];
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] elementos = lineas[i].Split(' ');
                matriz[i] = new string[elementos.Length];
                for (int j = 0; j < elementos.Length; j++)
                {
                    matriz[i][j] = elementos[j];
                }
            }

            // Mostramos mensaje de éxito
            MessageBox.Show("Archivo subido", "Alerta");

            // Imprime la matriz en la consola
            Console.WriteLine("La matriz añadida es: ");
            Console.WriteLine();
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Convertimos la matriz a enteros
            // Obtenemos el tamaño de las filas y columnas y creamos la matriz
            int filas = matriz.Length;
            int columnas = matriz[0].Length;

            int[][] matrizEnteros = new int[filas][];
            for (int i = 0; i < filas; i++)
            {
                matrizEnteros[i] = new int[columnas];
            }

            // Convierte la matriz de strings a una matriz de enteros
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    // intentamos convertir cada elemento de la matriz de strings a entero
                    int elementoEntero;
                    if (Int32.TryParse(matriz[i][j], out elementoEntero))
                    {
                        // si la conversión es exitosa, asignamos el valor entero a la posición correspondiente en la matriz de enteros
                        matrizEnteros[i][j] = (int)elementoEntero;
                    }
                    else
                    {
                        // si la conversión falla, podemos hacer algo como asignar un valor predeterminado (por ejemplo, cero) o lanzar una excepción
                        matrizEnteros[i][j] = -1;
                    }
                }
            }


            int col1 = 256 - 1; // Primera columna a intercambiar
            int col2 = 256 - 2; // Segunda columna a intercambiar


            for (int i = 0; i < matrizEnteros.Length; i++)
            {
                matrizEnteros[i] = matrizEnteros[i].Take(matrizEnteros[i].Length - 1).ToArray();
            }


            //imprimimos la matriz de enteros
            Console.WriteLine("Matriz de enteros casteada: ");
            for (int i = 0; i < matrizEnteros.Length; i++)
            {
                for (int j = 0; j < matrizEnteros[i].Length; j++)
                {
                    Console.Write(matrizEnteros[i][j] + " ");
                }
                Console.WriteLine();
            }
            //sacamos el nombre del archivo
            string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
            MessageBox.Show(nombreArchivo);
            //sacamos el id del archivo
            // Creamos el AFD y lo agregamos a la lista
            int id = int.Parse(nombreArchivo);


            //imprimimos el tamaño de filas y columnas de la matriz casteada
            MessageBox.Show("El tamaño de la matriz casteada es Fila: " + matrizEnteros.Length + " Columna: " + matrizEnteros[0].Length, "Alerta");
            AFD archivoAFD = new AFD(matrizEnteros, id);
            ListAFD.Add(archivoAFD);
            this.Close();




        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                // Usa la variable selectedFileName para hacer lo que quieras con el archivo seleccionado
                //asignamos a la variable archivo el nombre del archivo seleccionado
                archivo = selectedFileName;
                //imprimimos
                MessageBox.Show("El archivo seleccionado es: " + archivo, "Alerta");
            }
            btnSUBIR_ARCHIVO.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //recuperamos la columna 1 de el datagrid
            List<int> lista = new List<int>();
            for (int i = 0; i < listaTerminales.Rows.Count - 1; i++)
            {
                lista.Add(int.Parse(listaTerminales.Rows[i].Cells[1].Value.ToString()));
            }
            //imprimimos
            foreach (int item in lista)
            {
                MessageBox.Show(item.ToString());
            }
            NewTokens = lista;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog1.FileName;
                // Usa la variable selectedFileName para hacer lo que quieras con el archivo seleccionado
                //asignamos a la variable archivo el nombre del archivo seleccionado
                archivo = selectedFileName;
                //imprimimos
                MessageBox.Show("El archivo seleccionado es: " + archivo, "Alerta");
            }

            // Ruta: C:\Users\josec\source\repos\Practica1\bin\Debug
            string[][] matriz;

            // Lee el archivo línea por línea
            string[] lineas = File.ReadAllLines(archivo);

            // Crea la matriz a partir de las líneas del archivo
            matriz = new string[lineas.Length][];
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] elementos = lineas[i].Split(' ');
                matriz[i] = new string[elementos.Length];
                for (int j = 0; j < elementos.Length; j++)
                {
                    matriz[i][j] = elementos[j];
                }
            }

            // Mostramos mensaje de éxito
            MessageBox.Show("Archivo subido", "Alerta");

            // Imprime la matriz en la consola
            Console.WriteLine("La matriz añadida es: ");
            Console.WriteLine();
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Convertimos la matriz a enteros
            // Obtenemos el tamaño de las filas y columnas y creamos la matriz
            int filas = matriz.Length;
            int columnas = matriz[0].Length;

            int[][] matrizEnteros = new int[filas][];
            for (int i = 0; i < filas; i++)
            {
                matrizEnteros[i] = new int[columnas];
            }

            // Convierte la matriz de strings a una matriz de enteros
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    // intentamos convertir cada elemento de la matriz de strings a entero
                    int elementoEntero;
                    if (Int32.TryParse(matriz[i][j], out elementoEntero))
                    {
                        // si la conversión es exitosa, asignamos el valor entero a la posición correspondiente en la matriz de enteros
                        matrizEnteros[i][j] = (int)elementoEntero;
                    }
                    else
                    {
                        // si la conversión falla, podemos hacer algo como asignar un valor predeterminado (por ejemplo, cero) o lanzar una excepción
                        matrizEnteros[i][j] = -1;
                    }
                }
            }


            int col1 = 256 - 1; // Primera columna a intercambiar
            int col2 = 256 - 2; // Segunda columna a intercambiar


            for (int i = 0; i < matrizEnteros.Length; i++)
            {
                matrizEnteros[i] = matrizEnteros[i].Take(matrizEnteros[i].Length - 1).ToArray();
            }


            //imprimimos la matriz de enteros
            Console.WriteLine("Matriz de enteros casteada: ");
            for (int i = 0; i < matrizEnteros.Length; i++)
            {
                for (int j = 0; j < matrizEnteros[i].Length; j++)
                {
                    Console.Write(matrizEnteros[i][j] + " ");
                }
                Console.WriteLine();
            }
            //sacamos el nombre del archivo
            string nombreArchivo = Path.GetFileNameWithoutExtension(archivo);
            MessageBox.Show(nombreArchivo);
            //sacamos el id del archivo
            // Creamos el AFD y lo agregamos a la lista
            int id = int.Parse(nombreArchivo);


            //imprimimos el tamaño de filas y columnas de la matriz casteada
            MessageBox.Show("El tamaño de la matriz casteada es Fila: " + matrizEnteros.Length + " Columna: " + matrizEnteros[0].Length, "Alerta");
            AFD archivoAFD = new AFD(matrizEnteros, id);
            ListAFD.Add(archivoAFD);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //recuperamos la opcion del dropdown
            int opcion = (int)this.listaAFD.SelectedItem;
            //recuperamos cadenaSigma del textbox
            string cadena = cadenaSigma.Text;
            //recuperamos el AFD con ID 2
            AFD afd = ListAFD.Find(x => x.idAFD == opcion);
            //creamos un AFD con la tablaLL1
            //creamos el analizador lexico
            AnalizadorLexico analizadorLexico = new AnalizadorLexico(cadena,afd);
            //iteramos 
            List<int> tokens = new List<int>();
            List<string> lexemas = new List<string>();

            while (analizadorLexico.getIndiceCaracterActual() <= cadena.Length)
            {
                int token = analizadorLexico.yylex();
                Console.WriteLine("Token: " + token);
                Console.WriteLine("Lexema: " + analizadorLexico.getLexema());
                tokens.Add(token);
                lexemas.Add(analizadorLexico.getLexema());
                if (token != SimbolosEspeciales.ERROR)
                {
                    //agregamos en el datagridview
                    int n = infoAnalizador.Rows.Add();
                    //agregamos el ID del automata
                    infoAnalizador.Rows[n].Cells[0].Value = token.ToString();
                    infoAnalizador.Rows[n].Cells[1].Value = analizadorLexico.getLexema();

                }
                if (token == SimbolosEspeciales.FIN)
                {
                    break;
                }

            }

            //imprimimos el arreglo de tokens
            Console.WriteLine("Arreglo de tokens: ");
            foreach (int token in tokens)
            {
                Console.Write(token + " ");
            }
            Console.WriteLine();
            //imprimimos el arreglo de lexemas
            Console.WriteLine("Arreglo de lexemas: ");
            foreach (string lexema in lexemas)
            {
                Console.Write(lexema + " ");
            }
            Console.WriteLine();

            //mostramos los tokens y lexemas en el dataviewgrid
            //agregamos los AFND al data grid view

            i = 0;
            foreach (int token in tokens)
            {
                //adicionamos un nuevo renglon 
                int n = infoAnalizador.Rows.Add();
                //agregamos el ID del automata
                infoAnalizador.Rows[n].Cells[0].Value = token.ToString();
                infoAnalizador.Rows[n].Cells[1].Value = lexemas[i];
                //agregamos un checkbox a la siguiente columna
                i++;
                if (i < tokens.Count() - 2)
                    break;
            }
            //eliminamos la ultima fila del datagridview
            // infoAnalizador.Rows.RemoveAt(tokens.Count);



        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sigma = cadenaSigma.Text;
            //recuperamos el AFD
            int opcion = (int)this.listaAFD.SelectedItem;
            //recuperamos el AFD con su ID
            AFD afd = ListAFD.Find(x => x.idAFD == opcion);

            //usamos el metodo de la ClassTablaLL1 para analizar sintacticamente
            ClassTablaLL1 tablaLL1 = new ClassTablaLL1(TablaLL1, NewTokens, terminales, aux);

            //imprimimos la tabla
            tablaLL1.impTabLL1();
            //
            bool res = tablaLL1.AnalizarSin(afd, sigma, dataListaAFND, aux);

            if (res)
            {
                MessageBox.Show("Cadena aceptada");
            }
            else
            {
                MessageBox.Show("Cadena no aceptada");
            }



           


        }

      
        private void dataListaAFND_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

   }
