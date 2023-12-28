using System.Drawing;
using System.Windows.Forms;

namespace Practica1.Graficos
{
    public partial class GraficoBasico : Form
    {
        bool band = false;
        private char C_inf, C_sup;
        private int e1, e2;

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

        }

        public GraficoBasico(int[]edos, char[]trans)
        {
            InitializeComponent();
            C_inf = trans[0];
            C_sup = trans[1];
            e1 = edos[0];
            e2 = edos[1];

            if(C_inf == C_sup)
            {
                //asignamos los valores a los labels
                inicial.Text = e1.ToString();
                final.Text = e2.ToString();
                rango.Text = C_inf.ToString();

            }
            else
            {
                //asignamos los valores a los labels
                inicial.Text = e1.ToString();
                final.Text = e2.ToString();
                rango.Text = "[ "+C_inf+", "+C_sup+" ]";
            }
        }

    }
}
