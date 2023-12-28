using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.Forms
{
    public partial class FormAnalizar_Sintaxis : Form
    {
        List<AFD> ListAFD = new List<AFD>();
        public static int i = 0;
        private string archivo;
        ClassEvalMatriz EvalMatrices;
        Dictionary<char, List<List<int>> > HashMAT = new Dictionary<char, List<List<int>>>();
        List<string> operaciones = new List<string>{"Suma","Resta","Multiplicación"};
        private char auxHash;

        public FormAnalizar_Sintaxis(List<AFD> listAFD, Dictionary<char, List<List<int>>> hashMAT)
        {
            InitializeComponent();
            ListAFD = listAFD;
            btnSUBIR_ARCHIVO.Enabled = false;
            btnSelect.Enabled = false;
            HashMAT = hashMAT;
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

        private void FormAnalizar_Sintaxis_Load(object sender, EventArgs e)
        {
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

            //AGREGAMOS LOS KEY AL COMBOBOX
            foreach (KeyValuePair<char, List<List<int>>> entry in HashMAT)
            {
                boxmatriz1.Items.Add(entry.Key);
            }
            //AGREGAMOS LOS KEY AL COMOBOX 2
            foreach (KeyValuePair<char, List<List<int>>> entry in HashMAT)
            {
                boxmatriz2.Items.Add(entry.Key);
            }

            //agregamos las operaciones al comboBox
            foreach (string operacion in operaciones)
            {
                boxOperacion.Items.Add(operacion);
            }




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
            //agregamos el automata
            AFD archivoAFD = new AFD(matrizEnteros, id);
            ListAFD.Add(archivoAFD);
            this.Close();


        }

       
        
        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            bool Result;
            List<List<int>> prueba = new List<List<int>>();
            string CadenaAnalizar1 = CadenaAnalizar.Text;
            Console.WriteLine("Cadena a analizar: " + CadenaAnalizar1);
            //recuperamos el automata
            int idAFD = int.Parse(listaAFD.SelectedItem.ToString());
            AFD automata = ListAFD.Find(x => x.idAFD == idAFD);
            //mostramos el tamaño de la matriz
            MessageBox.Show("El tamaño de la matriz es Fila: " + automata.TransicionesAFD.Length + " Columna: " + automata.TransicionesAFD[0].Length, "Alerta");


            //mostramos el id del afd
            MessageBox.Show("El id del AFD es: " + automata.idAFD, "Alerta");
            //mostramos la cadena a analizar
            MessageBox.Show("La cadena a analizar es: " + CadenaAnalizar1, "Alerta");

            //EvalMatrices.Expresion = CadenaAnalizar.Text;
            //EvalMatrices.SetExpresion(CadenaAnalizar1);
            //EvalMatrices.L.SetSigma();
            ClassEvalMatriz analizadorSintactico = new ClassEvalMatriz(CadenaAnalizar1, automata);


            Result = analizadorSintactico.IniEvalMatrices();
            if (Result)
            {
                MessageBox.Show("Expresión sintácticamente Correcta", "Aviso");
                //AGREGAMOS LA MATRIZ AL HASHMAP
                //CREAMOS UN HASMAP DE MATRICES AUXILIAR
                Dictionary<char, List<List<int>>> aux = new Dictionary<char, List<List<int>>>();
                aux = analizadorSintactico.getMAT();
                
                //recuperamos la matriz del hashmap
                List<List<int>> auxMat = new List<List<int>>();

                //recorremos el hashmap
                foreach (KeyValuePair<char, List<List<int>>> kvp in aux)
                {
                    //imprimimos la clave
                    Console.WriteLine("MATRIZ = {0}", kvp.Key);

                    //imprimimos el valor
                    foreach (List<int> lista in kvp.Value)
                    {
                        //imprimimos el valor de la lista
                        foreach (int n in lista)
                        {
                            Console.Write("{0} ", n);
                        }
                        Console.WriteLine();
                    }
                    //guardamos la matriz en una variable auxiliar
                    auxMat = kvp.Value;
                    auxHash = kvp.Key;
                }


                //agregamos la matriz al hashmap
                if ( HashMAT.ContainsKey(auxHash) )
                {
                    MessageBox.Show("La matriz ya existe en el hashmap", "Aviso");
                }
                else
                {
                    HashMAT.Add(auxHash, auxMat);
                    MessageBox.Show("La matriz se ha agregado al hashmap", "Aviso");
                    //MOSTRAMOS CUANTOS DATOS HAY EN EL HASHMAP
                    MessageBox.Show("Hay " + HashMAT.Count + " datos en el hashmap", "Aviso");
                    //MOSTRAMOS LAS MATRICES DEL HASHMAP

                    Console.WriteLine("MATRICES RETORNADAS EN LA PRIMERA FASE");
                    foreach (KeyValuePair<char, List<List<int>>> kvp in HashMAT)
                    {
                        //imprimimos la clave
                        Console.WriteLine("MATRIZ = {0}", kvp.Key);
                        //imprimimos el valor
                        foreach (List<int> lista in kvp.Value)
                        {
                            foreach (int elemento in lista)
                            {
                                Console.Write(elemento + " ");
                            }
                            Console.WriteLine();
                        }
                    }

                    //cerramos el formulario de analizar
                    this.Close();
                }


            }
            else
            {
                MessageBox.Show("Expresión sintácticamente Incorrecta", "Aviso");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //guardamos la matriz en un hashmap

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //recuperamos los key de las matrices de los droplist
            char key1 = char.Parse(boxmatriz1.SelectedItem.ToString());
            char key2 = char.Parse(boxmatriz2.SelectedItem.ToString());

            //recuperamos la opcion del droplist operaciones
            string operacion = boxOperacion.SelectedItem.ToString();

            //recuperamos las matrices del hashmap
            List<List<int>> matriz1 = HashMAT[key1];
            List<List<int>> matriz2 = HashMAT[key2];





            //IMPRIMMOS EN CONSOLA AMBAS MATRICES
            ImprimirMatriz(matriz1);
            ImprimirMatriz(matriz2);


            //DETERMINAMOS EL TAMAÑO DE LAS FILAS Y COLUMNAS DE LAS MATRICES
            int filas1 = matriz1.Count;
            int columnas1 = matriz1[0].Count;
            int filas2 = matriz2.Count;
            int columnas2 = matriz2[0].Count;

            //TODO: VERIFICAR QUE IMPRIMA BIEN, SIN REVISAR
            // Limpiar las filas existentes en el DataGridView
            dataMat1.Rows.Clear();
            dataMat2.Rows.Clear();

            //Creamos el dataMat1 con el tamaño de filas1 y columnas1
            dataMat1.ColumnCount = columnas1;
            dataMat1.RowCount = filas1;
            
            dataMat2.ColumnCount = columnas2;
            dataMat2.RowCount = filas2;

            //agregamos los valores a la dataMat1
            for (int i = 0; i < filas1; i++)
            {
                for (int j = 0; j < columnas1; j++)
                {
                    dataMat1.Rows[i].Cells[j].Value = matriz1[i][j];
                }
            }
            //agregamos los valores a la datamat2
            for (int i = 0; i < filas2; i++)
            {
                for (int j = 0; j < columnas2; j++)
                {
                    dataMat2.Rows[i].Cells[j].Value = matriz2[i][j];
                }
            }

            //REALIZAMOS LA OPERACION SELECCIONADA
            List<List<int>> resultado = new List<List<int>>();
            switch (operacion)
            {
                case "Suma":
                    resultado = SumarMatrices(matriz1, matriz2);
                    break;
                case "Resta":
                    resultado = RestarMatrices(matriz1, matriz2);
                    break;
                case "Multiplicación":
                    resultado = MultiplicarMatrices(matriz1, matriz2);
                    break;
            }


            //mostramos el resultado en el dataMatRes
            dataMatRes.ColumnCount = resultado[0].Count;
            dataMatRes.RowCount = resultado.Count;

            for (int i = 0; i < resultado.Count; i++)
            {
                for (int j = 0; j < resultado[i].Count; j++)
                {
                    dataMatRes.Rows[i].Cells[j].Value = resultado[i][j];
                }
            }




          


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
