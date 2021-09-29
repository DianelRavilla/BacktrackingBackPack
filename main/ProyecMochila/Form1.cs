using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecMochila
{
    public partial class INTERFAZ : Form
    {
        MOCHILA Base, Optimo;
        List<ELEMENTO> elementos = new List<ELEMENTO>();

        int turno = 0;
        public INTERFAZ()
        {
            InitializeComponent();           
            MOCHILA_GIF(turno);
        }
        
        public void llenarMochila(MOCHILA m_base, List<ELEMENTO> elementos, bool llena, MOCHILA m_opt)
        {
            //si esta llena
            if (llena)
            {
                //compruebo si tiene mas beneficio que otra
                if (m_base.beneficio > m_opt.beneficio)
                {

                    ELEMENTO[] elementosMochBase = m_base.elementos;
                    m_opt.clear();

                    //metemos los elementos
                    foreach (ELEMENTO e in elementosMochBase)
                    {
                        if (e != null)
                        {
                            m_opt.Añadir(e);
                        }
                    }
                }
            }
            else
            {
                //Recorre los elementos
                for (int i = 0; i < elementos.Count; i++)
                {
                    //si existe el elemento
                    if (!m_base.existeElemento(elementos[i]))
                    {
                        //Si el peso de la mochila se supera, indicamos que esta llena
                        if (m_base.pesoMaximo > m_base.peso + elementos[i].peso)
                        {
                            m_base.Añadir(elementos[i]);                        //añadimos
                            llenarMochila(m_base, elementos, false, m_opt);
                            m_base.eliminarElemento(elementos[i]);              // lo eliminamos
                        }
                        else
                        {
                            llenarMochila(m_base, elementos, true, m_opt);
                        }
                    }
                }
            }
        }      

        private void BtnEmpezar_Click(object sender, EventArgs e)
        {
            try
            {
                llenarMochila(Base, elementos, false, Optimo);
                MostrarResultadoPerron();
            }
            catch { MessageBox.Show("No se puede empezar si no hay elementos o el peso máximo de la mochila no esta establecida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand); }
        }

        private void MostrarResultadoPerron()
        {
            try
            {
                Application.DoEvents();
                Thread.Sleep(10);
                IMAGEN_MOCHILA.Left = 170;
                Application.DoEvents();
                Thread.Sleep(10);
                IMAGEN_MOCHILA.Left = 190;
                Application.DoEvents();
                Thread.Sleep(10);
                IMAGEN_MOCHILA.Left = 210;
                Application.DoEvents();
                Thread.Sleep(10);
                IMAGEN_MOCHILA.Left = 230;

                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "E";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "EL";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELE";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEM";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEME";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMEN";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENT";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTO";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS E";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN L";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA M";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA MO";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA MOC";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA MOCH";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA MOCHI";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA MOCHIL";
                Application.DoEvents();
                Thread.Sleep(20);
                LABEL_ELEMENTOSENLAMOCHILA.Text = "ELEMENTOS EN LA MOCHILA";

                int n = Optimo.peso;
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_PESO.Text = "P";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_PESO.Text = "PE";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_PESO.Text = "PES";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_PESO.Text = "PESO";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_PESO.Text = "PESO:";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_PESO.Text = "PESO: " + Optimo.peso;

                int m = Optimo.beneficio;    
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "B";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BE";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BEN";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENE";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENEF";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENEFI";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENEFIC";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENEFICI";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENEFICIO";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENEFICIO:";
                Application.DoEvents();
                Thread.Sleep(50);
                LABEL_BENEFICIO.Text = "BENEFICIO: " + Optimo.beneficio;

                Optimo.MostrarElementos(lbxELEMENTOS);
            }
            catch { };
        }

        private void BtnReiniciar_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnAñadirElemento_Click(object sender, EventArgs e)
        {
            try
            {
                int peso = Int32.Parse(txtPESO.Text);
                int bene = Int32.Parse(txtBENEFICIO.Text);
                string nombre = "ELEMENTO " + (elementos.Count + 1);

                txtPESO.Text = "";
                txtBENEFICIO.Text = "";

                if (elementos.Count < 6)
                { 
                    elementos.Add(new ELEMENTO(peso, bene, nombre));
                    lbxMostrar.Items.Add("ELEMENTO " + elementos.Count + "\tPeso: " + peso + "\tBeneficio: " + bene);
                }
                else
                    MessageBox.Show("La mochila solo puede cargar 6 elementos como máximo", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch { MessageBox.Show("El elemento debe tener un peso y un beneficio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void IMAGEN_MOCHILA_MouseDown(object sender, MouseEventArgs e)
        {
            if (turno == 0)
                turno = 1;
            else if (turno == 1)
                turno = 2;
            else if (turno == 2)
                turno = 0;
            MOCHILA_GIF(turno);
        }

        private void MOCHILA_GIF(int t)
        {
            switch (t)
            {
                case 0:
                    IMAGEN_MOCHILA.Image = Properties.Resources.MOCHILA1_GIF;
                    break;
                case 1:
                    IMAGEN_MOCHILA.Image = Properties.Resources.MOCHILA2_GIF;
                    break;
                case 2:
                    IMAGEN_MOCHILA.Image = Properties.Resources.MOCHILA3_GIF;
                    break;
            }
        }

        private void txtPesoMaximo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtPesoMaximo.Text) <= 100)
                {
                    Base = new MOCHILA(Convert.ToInt32(txtPesoMaximo.Text), 4);
                    Optimo = new MOCHILA(Convert.ToInt32(txtPesoMaximo.Text), 4);
                    LABEL_PESOMAXIMO.Text = "Peso máximo: " + txtPesoMaximo.Text;
                }
                else
                {
                    MessageBox.Show("El limite para el peso maximo es 100", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtPesoMaximo.Text = "";
                }
            }
            catch { LABEL_PESOMAXIMO.Text = "Peso máximo: 0"; }
        }

        private void BTN_SALIR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BTN_MINIMIZAR_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
