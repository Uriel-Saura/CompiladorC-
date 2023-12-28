using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Practica1.Forms
{
    public partial class FormOpcion : Form
    {
        public List<AFND> ListAFND = new List<AFND>();
        SoundPlayer player = new SoundPlayer();

        public FormOpcion(List<AFND> listAFND)
        {
            InitializeComponent();
            ListAFND = listAFND;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pensanding cual escoger","Chascarrillo");
            player.SoundLocation = "C:\\Users\\josec\\source\\repos\\Practica1\\bin\\Debug\\Music\\fakiu.wav";
            player.Play();
        }

        private void FormOpcion_Load(object sender, EventArgs e)
        {
            //Mostramos los AFND en los comboBox
            foreach (AFND afnd in ListAFND)
            {
                lista.Items.Add(afnd.IdAFND);
            }
        }

        private void btnConcat_AFND_Click(object sender, EventArgs e)
        {
            int opcion;
            //creamos AFND Auxiliar
            AFND aux = new AFND();
            opcion = (int)this.lista.SelectedItem;
            //mostramos los que unimos
            MessageBox.Show("El automata al que se le aplicará el opcional es: " + opcion);
            //aplicamos opcional los automatas seleccionados iterando la lista
            foreach (AFND afnd in ListAFND)
            {
                if (afnd.IdAFND == opcion)
                {
                    aux = afnd.Opcional();
                }
            }

            //elminamos los automatas que hemos unido
            //ListAFND.RemoveAt(opcion - 1);
            ListAFND.RemoveAll(afnd => afnd.IdAFND == opcion);

            ListAFND.Add(aux);
            //cerramos el formulario
            this.Close();
        }
    }
}
