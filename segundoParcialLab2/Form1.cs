using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace segundoParcialLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool validacion(string dato, string num)
        {
            bool bandera = false;

            if(dato == "int")
            {
                try
                {
                    Convert.ToInt32(num);
                    bandera = true;
                }
                catch(Exception e)
                {
                    bandera = false;
                }
            }
            else if(dato == "double")
            {
                try
                {
                    Convert.ToDouble(num);
                    bandera = true;
                }
                catch (Exception e)
                {
                    bandera = false;
                }
            }

            return bandera;
        }

        private void buttonPrecioFinal_Click(object sender, EventArgs e)
        {
            double precioFinal;

            if((validacion("double", textBoxPrecio.Text) == true) && (validacion("int", textBoxCantidad.Text) == true))
            {
                if (radioPantalon.Checked == true)   //Si es un pantalón
                {
                    Pantalon pant = new Pantalon(checkBoxBermuda.Checked, Convert.ToDouble(textBoxPrecio.Text), radioButtonPremium.Checked);

                    precioFinal = pant.calcularPrecio(Convert.ToInt32(textBoxCantidad.Text));
                    MessageBox.Show("$" + precioFinal, "Precio calculado");
                }
                else
                {
                    Camisa cam = new Camisa(checkBoxMangaCorta.Checked, Convert.ToDouble(textBoxPrecio.Text), radioButtonPremium.Checked);

                    precioFinal = cam.calcularPrecio(Convert.ToInt32(textBoxCantidad.Text));
                    MessageBox.Show("$" + precioFinal, "Precio calculado");
                }

                textBoxPrecio.BackColor = System.Drawing.Color.White;
                textBoxCantidad.BackColor = System.Drawing.Color.White;
                textBoxPrecio.Text = "";
                textBoxCantidad.Text = "";
            }
            else
            {
                if (validacion("double", textBoxPrecio.Text) == false)
                    textBoxPrecio.BackColor = System.Drawing.Color.Orange;
                else
                    textBoxPrecio.BackColor = System.Drawing.Color.White;


                if (validacion("int", textBoxCantidad.Text) == false)
                    textBoxCantidad.BackColor = System.Drawing.Color.Orange;
                else
                    textBoxCantidad.BackColor = System.Drawing.Color.White;
            }


            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioCamisa.Checked = true;
            radioButtonStandard.Checked = true;
            
        }

        private void radioCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (radioCamisa.Checked == true)
            {
                checkBoxBermuda.Enabled = false;
                checkBoxMangaCorta.Enabled = true;
            }
            else
            {
                checkBoxMangaCorta.Enabled = false;
                checkBoxBermuda.Enabled = true;
            }
                
        }
    }
}
