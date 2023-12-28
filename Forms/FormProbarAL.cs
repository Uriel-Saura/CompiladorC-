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

namespace Practica1.Forms
{
    public partial class FormProbarAL : Form
    {
        List<AFD> ListAFD = new List<AFD>();
        public static int i = 0;
        private string archivo;
        public FormProbarAL(List<AFD>AFDS)
        {
            InitializeComponent();
            ListAFD = AFDS;
            btnSUBIR_ARCHIVO.Enabled = false;
            btnSelect.Enabled = false;
        }

        private void FormProbarAL_Load(object sender, EventArgs e)
        {
            
            if(ListAFD.Count == 0)
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

            //



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
          

            int col1 =256-1; // Primera columna a intercambiar
            int col2 = 256 -2; // Segunda columna a intercambiar

         
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
            MessageBox.Show("El tamaño de la matriz casteada es Fila: " + matrizEnteros.Length + " Columna: " + matrizEnteros[0].Length,"Alerta");
            AFD archivoAFD = new AFD(matrizEnteros, id);
            ListAFD.Add(archivoAFD);
            this.Close();

        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            //recuperamos el id del AFD a evaluar
            int id = (int)this.listaAFD.SelectedItem;
            //recuperamos la cadena del textbox
            string cadena = CadenaAnalizar.Text.Trim();
            //recuperamos el AFD elegido
            AFD afd = new AFD();
            foreach (AFD afd1 in ListAFD)
            {
                if (afd1.idAFD == id)
                {
                    afd = afd1;
                }
            }
            //creamos el analizador lexico
            AnalizadorLexico analizadorLexico = new AnalizadorLexico(cadena,afd);
            //iteramos 
            List<int> tokens = new List<int>();
            List<string>lexemas = new List<string>();
            
            while(analizadorLexico.getIndiceCaracterActual() <= cadena.Length )
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
                if(token == SimbolosEspeciales.FIN)
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
                if (i < tokens.Count()-2)
                    break;
            }
            //eliminamos la ultima fila del datagridview
           // infoAnalizador.Rows.RemoveAt(tokens.Count);





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
    }
}
