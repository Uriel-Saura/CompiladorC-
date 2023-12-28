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
    public partial class FormKlene : Form
    {
        public List<AFND> ListAFND = new List<AFND>();

        public FormKlene(List<AFND> automatas)
        {
            InitializeComponent();
            ListAFND = automatas;

        }

        private void FormKlene_Load(object sender, EventArgs e)
        {
            //Mostramos los AFND en los comboBox
            foreach (AFND afnd in ListAFND)
            {
                lista.Items.Add(afnd.IdAFND);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pensanding en un memingo", "Chistosito el alumno");
        }

        private void btnConcat_AFND_Click(object sender, EventArgs e)
        {
            int klenne;
            //creamos AFND Auxiliar
            AFND aux = new AFND();
            klenne = (int)this.lista.SelectedItem;
            //mostramos los que unimos
            MessageBox.Show("El automata al que se le aplicará la Cerradura Klenne es: " + klenne);
            //Unimos los automatas seleccionados
            // aux = ListAFND[klenne - 1].CerrKleen();
            //aplicamos klenne los automatas seleccionados iterando la lista
            foreach (AFND afnd in ListAFND)
            {
                if (afnd.IdAFND == klenne)
                {
                    aux = afnd.CerrKleen();
                }
            }

            //elminamos los automatas que hemos unido
            // ListAFND.RemoveAt(klenne - 1);
            ListAFND.RemoveAll(afnd => afnd.IdAFND == klenne);

            ListAFND.Add(aux);
            //cerramos el formulario
            this.Close();
        }
    }
}
