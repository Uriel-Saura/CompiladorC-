using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Media;

namespace Practica1
{

    public partial class Form1 : Form
    {

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activateForm;

        public static List<AFND> ListAFND = new List<AFND>();
        public static List<AFD> ListAFD = new List<AFD>();
        //creamos una lista auxiliar
        public static List<AFND> auxlist = new List<AFND>();
        //hashmap de matrices globales
        public Dictionary<char, List<List<int>>> HashMAT = new Dictionary<char, List<List<int>>>();

        //constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Básico
            OpenChildForm(new Forms.FormBasico(ListAFND), sender);
            //imprimimos en terminal el automata
            foreach (AFND automata in ListAFND)
            {
                automata.getInfo();
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUnir(ListAFND), sender);
            //imprmimos en terminal la union
            foreach (AFND automata in ListAFND)
            {
                automata.getInfo();
            }

        }



        private void btnConcatenar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConcatenar(ListAFND), sender);
            //imprmimos en terminal la union
            foreach (AFND automata in ListAFND)
            {
                automata.getInfo();
            }

        }

        private void btnCerradura_Positiva_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.FormPositiva(ListAFND), sender);
            //imprmimos en terminal la union
            foreach (AFND automata in ListAFND)
            {
                automata.getInfo();
            }
        }

        private void btnCerradura_Klene_Click(object sender, EventArgs e)
        {
            Console.WriteLine();
            OpenChildForm(new Forms.FormKlene(ListAFND), sender);
            //imprmimos en terminal la union
            Console.WriteLine("Cerradura de kleene");
            foreach (AFND automata in ListAFND)
            {
                automata.getInfo();
            }
        }

        private void btnOpcional_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormOpcion(ListAFND), sender);
        }

        private void btnER_AFND_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormER(ListAFND,ListAFD), sender);
        }

        private void btnAnalizador_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormUAnalizador_Lexico(ListAFND), sender);
            //imprimimos los ID de los AFND
            foreach (AFND automata in ListAFND)
            {
                Console.WriteLine(automata.IdAFND);
            }
            //imprmimos los tokens
            foreach (AFND automata in ListAFND)
            {
                //sacamos del hashet de  EdoAcep su token
                automata.imprimirEdosAcept();

            }
        }

        private void btnAFND_AFD_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAFND_AFD(ListAFND, ListAFD), sender);
        }

        private void btnProbar_AL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProbarAL(ListAFD), sender);
        }

        private void btnAnaSintac_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormAnalizar_Sintaxis(ListAFD,HashMAT), sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDescensoRecursivoGramatica(ListAFD), sender);
            //boton decenso recursivo gramaticas

        }

        //methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();

                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);

                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(36, 0, 71);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

            ActivateButton(btnSender);
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDektopPanel.Controls.Add(childForm);
            this.panelDektopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTittle.Text = childForm.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No preguntes, solo gozalo guapeton :)", "Chascarrillo");

        }

        
    }
}
