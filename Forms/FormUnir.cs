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
    public partial class FormUnir : Form
    {

        public List<AFND> ListAFND = new List<AFND>();

        public FormUnir(List<AFND> automatas)
        {
            InitializeComponent();
            ListAFND = automatas;
        }

        private void FormUnir_Load(object sender, EventArgs e)
        {
            //Mostramos los AFND en los comboBox
            foreach (AFND afnd in ListAFND)
            {
                unir.Items.Add(afnd.IdAFND);
                con.Items.Add(afnd.IdAFND);
            }
        }

        private void btnUnir_AFND_Click(object sender, EventArgs e)
        {
            int unir, con;
            //creamos AFND Auxiliar
            AFND aux = new AFND();
            unir = (int) this.unir.SelectedItem;
            con =(int) this.con.SelectedItem;
            if(unir == con)
            {
                //si son iguales mostramos un mensaje de error
                 MessageBox.Show("No se pueden unir 2 automatas con el mismo ID", "Alerta");
                //no se puede recargamos el formulario
                this.Refresh();
            }
            else
            {
                //mostramos los que unimos
                MessageBox.Show("Unimos el automata " + unir + " con el automata " + con);
                //Unimos los automatas seleccionados iterando la lista
                foreach (AFND afnd in ListAFND)
                {
                    if (afnd.IdAFND == unir)
                    {
                        foreach (AFND afnd2 in ListAFND)
                        {
                            if (afnd2.IdAFND == con)
                            {
                                aux = afnd.UnirAFND(afnd2);
                            }
                        }
                    }
                }


                //elminamos los automatas que hemos unido
                //ListAFND.RemoveAt(unir - 1);
                //ListAFND.RemoveAt(con - 2);
                //eliminamos los automatas que hemos unido
                ListAFND.RemoveAll(afnd => afnd.IdAFND == unir || afnd.IdAFND == con);


                ListAFND.Add(aux);

                //cerramos el formulario
                this.Close();
            }

        }
    }
}
