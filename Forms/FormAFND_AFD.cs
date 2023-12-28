using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Practica1.Forms
{
    public partial class FormAFND_AFD : Form
    {
        public List<AFND> ListAFND = new List<AFND>();
        public List<AFD> ListAFD = new List<AFD>();
        public FormAFND_AFD(List<AFND> listAFND, List<AFD> listAFD)
        {
            InitializeComponent();
            ListAFND = listAFND;
            ListAFD = listAFD;
        }

        private void btnCrear_AFD_Click(object sender, EventArgs e)
        {

            //creamos el AFD
            AFD afd = new AFD();
            //creamos un AFND auxiliar
            AFND aux = new AFND();
            //recuperamos el ID del automata resultante 
            int idResultante = int.Parse(IdAFD.Text);
            //recuperamos el id del automata a convertir
            int idAFND = int.Parse(lista.Text);
            //recuperamos el AFND seleccionado
            foreach (AFND afnd1 in ListAFND)
            {
                if (afnd1.IdAFND == idAFND)
                {
                    aux = afnd1;
                }
            }
            //creamos el AFD
            afd = aux.ConvAFNDaAFD();
            //asignamos el ID del AFD
            afd.idAFD = idResultante;
            //IMPRIMIMOS LA MATRIZ EN LA TERMINAL
            afd.getInf();
            //agregamos el AFD a la lista
            ListAFD.Add(afd);

            int[][] matrizAFD = afd.TransicionesAFD;
            //creamos el DataGridView con el tamaño de la matrizAFD
            infoAFD.ColumnCount = matrizAFD[0].Length;
            infoAFD.RowCount = matrizAFD.Length;
            //rellenamos el DataGridView
            for (int i = 0; i < matrizAFD.Length; i++)
            {
                for (int j = 0; j < matrizAFD[0].Length; j++)
                {
                    infoAFD.Rows[i].Cells[j].Value = matrizAFD[i][j].ToString();
                }
            }
            //imprimimos el tamaño de las filas y columnas
            MessageBox.Show("Filas: " + matrizAFD.Length + " Columnas: " + matrizAFD[0].Length);
            // Crear el objeto StreamWriter para escribir en el archivo
            using (StreamWriter sw = new StreamWriter(idAFND.ToString() + ".txt"))
            {
                // Recorrer la matriz y escribir cada elemento en el archivo
                for (int i = 0; i < matrizAFD.Length; i++)
                {
                    for (int j = 0; j < matrizAFD[0].Length; j++)
                    {
                        sw.Write(matrizAFD[i][j].ToString() + " ");
                    }
                    sw.WriteLine();
                }
            }
            //guardamos el txt en una ruta especificada
            File.Copy(idAFND.ToString()  +".txt", @"C:\Users\uriel\OneDrive\Documentos\SemestreVI\Compiladores\Practica1\bin\Debug\AFNDS\" + idResultante+".txt", true);
            //elmininamos el txt creado en una ruta especificada

            // Especificar la ruta y el nombre del archivo
            string ruta = "C:\\Users\\uriel\\OneDrive\\Documentos\\SemestreVI\\Practica1\\bin\\Debug\\"+idResultante+".txt";

            // Verificar si el archivo existe
            if (File.Exists(ruta))
            {
                // Eliminar el archivo
                File.Delete(ruta);
            }



            //guardamos la matriz en un archivo de excel
            // Creamos el objeto Excel
            Excel.Application excel = new Excel.Application();
            // Crear un libro de trabajo y una hoja de cálculo
            Excel.Workbook libro = excel.Workbooks.Add();
            Excel.Worksheet hoja = (Excel.Worksheet)libro.ActiveSheet;
            // Recorremos la matriz y la vamos escribiendo en el archivo de Excel
            for (int i = 0; i < matrizAFD.Length; i++)
            {
                for (int j = 0; j < matrizAFD[0].Length; j++)
                {
                    excel.Cells[i + 1, j + 1] = matrizAFD[i][j].ToString();
                }
            }
            //guardamos el archivo en la ruta especificada C:\Users\josec\source\repos\Practica1\bin\Debug
            libro.SaveAs(@"C:\Users\uriel\OneDrive\Documentos\SemestreVI\Compiladores\Practica1\bin\Debug\AFNDS\" + idResultante+".xlsx");

            // Cerrar el libro de trabajo y Excel
            libro.Close();
            excel.Quit();

            Console.WriteLine("La matriz se ha guardado correctamente en el archivo matriz.txt");
            Console.ReadLine();
            


        }

        private void FormAFND_AFD_Load(object sender, EventArgs e)
        {
            //Mostramos los AFND en los comboBox
            foreach (AFND afnd in ListAFND)
            {
                lista.Items.Add(afnd.IdAFND);
            }
        }
    }
}
