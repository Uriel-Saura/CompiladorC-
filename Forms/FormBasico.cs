using Practica1.Graficos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DocumentFormat.OpenXml.Spreadsheet;

namespace Practica1.Forms
{

   

    public partial class FormBasico : Form
    {
        //Ocupamos una lista para almacenar los AFND para todo el programa
        public List<AFND> ListAFND = new List<AFND>();


        public FormBasico(List<AFND> automatas)
        {
            InitializeComponent();
            ListAFND = automatas;
            btnCrear_AFND.Enabled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCrear_AFND_Click(object sender, EventArgs e)
        {
              //verificamos si el checkbox esta activado
              AsciiConverter convertidor = new AsciiConverter();
             if (checkAscii.Checked)
            {
                MessageBox.Show("Se usará el ASCII", "Aviso");
                //recuperamos los valores ingresados en el textbox
                string caracterInf = Caracter_Inf.Text;
                string caracterSup = Caracter_Sup.Text;
                int id = Convert.ToInt32(ID_AFND.Text);
                AFND afnd = new AFND();
                int aux1 =  Convert.ToInt32(caracterInf), aux2 = Convert.ToInt32(caracterSup);

                char C_Inf = (char)aux1, C_Sup = (char)aux2;
         
                if (C_Inf == C_Sup)
                {
                    //convertimos los char a int
                    int aux11 = (int) C_Inf;
                    int aux22 = (int) C_Sup;

                    //converitmos a ASCII con el converidor
                    C_Inf = convertidor.ConvertToAscii(aux11);
                    C_Sup = convertidor.ConvertToAscii(aux22);

                    //Solo se toma el caracter inferior
                    //Creamos el AFND
                    afnd.CrearAFNDBasico(C_Inf, id);
                    //Lo añadimos a la lista
                    ListAFND.Add(afnd);
                    //reseteamos el formulario
                    ResetFormBasic();
                    //mostramos el AFND
                    afnd.MostrarAFND();

                }
                else
                {
                    //Creamos el AFND
                    afnd.CrearAFNDBasico(C_Inf, C_Sup, id);
                    //Lo añadimos a la lista
                    ListAFND.Add(afnd);
                    //reseteamos el formulario
                    ResetFormBasic();
                    //mostramos el AFND
                    afnd.MostrarAFND();

                }

           

            }
            else
            {
                MessageBox.Show("Se usa lo que ingresa", "Aviso");
                //Recuperamos los datos del formulario
                string caracterInf = Caracter_Inf.Text;
                string caracterSup = Caracter_Sup.Text;
                int id = Convert.ToInt32(ID_AFND.Text);

                char C_Inf = caracterInf[0];
                char C_Sup = caracterSup[0];
                AFND afnd = new AFND();

                if (C_Inf == C_Sup)
                {
                    //Solo se toma el caracter inferior
                    //Creamos el AFND
                    afnd.CrearAFNDBasico(C_Inf, id);
                    //Lo añadimos a la lista
                    ListAFND.Add(afnd);
                    //reseteamos el formulario
                    ResetFormBasic();
                    //mostramos el AFND
                    afnd.MostrarAFND();

                }
                else
                {
                    //Creamos el AFND
                    afnd.CrearAFNDBasico(C_Inf, C_Sup, id);
                    //Lo añadimos a la lista
                    ListAFND.Add(afnd);
                    //reseteamos el formulario
                    ResetFormBasic();
                    //mostramos el AFND
                    afnd.MostrarAFND();

                }
            }
        }

        private void ResetFormBasic()
        {
            // Restablecer los valores de los controles a sus valores predeterminados
            Caracter_Inf.Text = "";
            Caracter_Sup.Text = "";
            btnCrear_AFND.Enabled = true;
            ID_AFND.Text = "";
            // Establecer el foco en el primer control
            Caracter_Inf.Focus();
        }

        private void FormBasico_Load(object sender, EventArgs e)
        {
            //deshabilitamos el boton hasta que se validen los datos
            btnCrear_AFND.Enabled = true;

        }
 
        private void Caracter_Inf_TextChanged(object sender, EventArgs e)
        {

        }
        private void Caracter_Sup_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Fino padrino", "Chascarrillo");

        }
    }
}