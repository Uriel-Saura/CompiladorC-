using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica1.Forms
{
    public partial class FormUAnalizador_Lexico : Form
    {
        //Ocupamos una lista para almacenar los AFND para todo el programa
        public List<AFND> ListAFND = new List<AFND>();
        public FormUAnalizador_Lexico(List<AFND> automatas)
        {

            InitializeComponent();
            ListAFND = automatas;
        }

        private void FormUAnalizador_Lexico_Load(object sender, EventArgs e)
        {

            //agregamos los AFND al data grid view
            foreach (AFND automata in ListAFND)
            {
                //adicionamos un nuevo renglon 
                int n = listaAFND.Rows.Add();
                //agregamos el ID del automata
                listaAFND.Rows[n].Cells[0].Value = automata.IdAFND.ToString();
                //agregamos un checkbox a la siguiente columna
            }
            //agregamos una columna con checkboxes para seleccionar los automatas
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            //lo agregamos como segunda posicion
            listaAFND.Columns.Insert(1, chk);
            chk.HeaderText = "Seleccionar AFND'S";
            chk.Name = "chk";
            //ponerla enmedio
        



        }

        private void btnUNIR_AFNDS_Click(object sender, EventArgs e)
        {
            //recuperamos el ID del automata resultante y el token
            int idResultante = int.Parse(Id_AFDResultante.Text);

            // Crear una lista para almacenar los valores de la columna
            List<string> Tokens = new List<string>();

            //recuperamos los automatas seleccionados
            List<AFND> automatasSeleccionados = new List<AFND>();

            //recorremos el data grid view
            foreach (DataGridViewRow row in listaAFND.Rows)
            {
                //verificamos si el checkbox esta seleccionado
                if (Convert.ToBoolean(row.Cells["chk"].Value) == true)
                {
                    //recuperamos el ID del automata y el  token
                    int id = int.Parse(row.Cells[0].Value.ToString());
                    //buscamos el automata en la lista de automatas
                    foreach (AFND automata in ListAFND)
                    {
                        if (automata.IdAFND == id)
                        {
                            //agregamos el automata a la lista de automatas seleccionados
                            automatasSeleccionados.Add(automata);
                            //agregamos el token a la lista de tokens
                        }
                    }
                }
            }
            // Obtener el índice de la columna que se desea recorrer
            int indiceColumna = listaAFND.Columns["Token"].Index;
             // recorremos las filas del data grid y recuperamos unicamente los valores que tengan el checkbox seleccionado
             foreach (DataGridViewRow row in listaAFND.Rows)
            {
                    //verificamos si el checkbox esta seleccionado
                    if (Convert.ToBoolean(row.Cells["chk"].Value) == true)
                {
                        //recuperamos el token
                        string token = row.Cells[indiceColumna].Value.ToString();
                        //agregamos el token a la lista de tokens
                        Tokens.Add(token);
                    }
                }

            //se imprime una alerta para verificar
            MessageBox.Show("Se seleccionaron " + automatasSeleccionados.Count + " automatas");

            //imprime el Id de cada automata y su token
            foreach (AFND automata in automatasSeleccionados)
            {
                Console.WriteLine("Id del automata: "+automata.IdAFND);

            }
            foreach (string token in Tokens)
            {
                Console.WriteLine("Token: " + token);
            }

            // ya que se recupera creamos el AFD con union especial
            //creamos el automata resultante
            AFND resultante = new AFND();
            //iteramos la lista de AFND seleccionados y usamos el metodo UnionEspecialAFNDs(AFND,Token)
            //recuperamos el primer automata de la lista
           for(int i = 0; i < automatasSeleccionados.Count; i++)
            {
                resultante.UnionEspecialAFNDs(automatasSeleccionados[i], int.Parse(Tokens[i]));
            }
            //le asignamos el ID
            resultante.IdAFND = idResultante;
            MessageBox.Show("Se creo correctamente el AFND especial", "Alerta");
           
            foreach(AFND automata in automatasSeleccionados)
            {
                ListAFND.Remove(automata); 
            }
            //imprmimos el ID del resultante
            MessageBox.Show("ID del AFND Especial: " + resultante.IdAFND, "Alerta");
            //agregamos el automata nuevo
            ListAFND.Add(resultante);

            //recargamos el formulario
            this.Close();
           

        }
    
    

    
    
    }
}
