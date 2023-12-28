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
    public partial class FormConcatenar : Form
    {
        public List<AFND> ListAFND = new List<AFND>();
        public FormConcatenar(List<AFND> automatas)
        {
            InitializeComponent();
            ListAFND = automatas;

        }

        private void FormConcatenar_Load(object sender, EventArgs e)
        {
            //Mostramos los AFND en los comboBox
            foreach (AFND afnd in ListAFND)
            {
                concatenar.Items.Add(afnd.IdAFND);
                con.Items.Add(afnd.IdAFND);
            }
        }


        private void btnConcat_AFND_Click(object sender, EventArgs e)
        {
            int concatenar, con;
            //creamos AFND Auxiliar
            AFND aux = new AFND();
            concatenar = (int)this.concatenar.SelectedItem;
            con = (int)this.con.SelectedItem;
            if (concatenar == con)
            {
                //si son iguales mostramos un mensaje de error
                MessageBox.Show("No se pueden concatenar 2 automatas con el mismo ID", "Alerta");
                //no se puede recargamos el formulario
                this.Refresh();
            }
            else
            {
                //mostramos los que unimos
                MessageBox.Show("Unimos el automata " + concatenar + " con el automata " + con);
                //concatenamos los automatas seleccionados iterando la lista
                foreach (AFND afnd in ListAFND)
                {
                    if (afnd.IdAFND == concatenar)
                    {
                        foreach (AFND afnd2 in ListAFND)
                        {
                            if (afnd2.IdAFND == con)
                            {
                                aux = afnd.ConcAFND(afnd2);
                                //definimos otro id del aux 
                            }
                        }
                    }
                }



                //aux = ListAFND[concatenar - 1].ConcAFND(ListAFND[con - 1]);
                //elminamos los automatas que hemos unido
                // ListAFND.RemoveAt(concatenar - 1);
                //ListAFND.RemoveAt(con - 2);
                // Eliminamos los automatas que hemos unido basándonos en su ID
                ListAFND.RemoveAll(afnd => afnd.IdAFND == concatenar || afnd.IdAFND == con);

                ListAFND.Add(aux);


                //cerramos el formulario
                this.Close();
            }
        }



    }
}
