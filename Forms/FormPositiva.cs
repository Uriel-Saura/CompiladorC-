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
    public partial class FormPositiva : Form
    {
        public List<AFND> ListAFND = new List<AFND>();

        public FormPositiva(List<AFND> automatas)
        {
            InitializeComponent();
            ListAFND = automatas;

        }

        private void FormPositiva_Load(object sender, EventArgs e)
        {
            //Mostramos los AFND en los comboBox
            foreach (AFND afnd in ListAFND)
            {
                lista.Items.Add(afnd.IdAFND);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muy chistoso la verdad", "Chistosito el alumno");

        }

        private void btnConcat_AFND_Click(object sender, EventArgs e)
        {
            int positiva;
            //creamos AFND Auxiliar
            AFND aux = new AFND();
            positiva = (int)this.lista.SelectedItem;
                //mostramos los que unimos
                MessageBox.Show("El automata al que se le aplicará la Cerradura positiva es: " + positiva);
            //aplicamos cerradura positiva los automatas seleccionados iterando la lista
            foreach (AFND afnd in ListAFND)
            {
                if (afnd.IdAFND == positiva)
                {
                            aux = afnd.CerrPos();
                }
            }

            //elminamos los automatas que hemos unido
            //ListAFND.RemoveAt(positiva - 1);
            ListAFND.RemoveAll(afnd => afnd.IdAFND == positiva);

            ListAFND.Add(aux);
                //cerramos el formulario
                this.Close();
        }
    }
}
