using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ppvolume
{
    public partial class Form1 : Form


    {
        Double raio;
        Double altura;
        Double volume;



        public Form1()
        {
            InitializeComponent();
        }




        private void txtRaio_Validated(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnFechar)
                return;


            if (!double.TryParse(txtRaio.Text, out raio))
            {
                MessageBox.Show("Raio Inválido!");
                txtRaio.Focus();
            }
            else
            {
                if (raio <= 0)

                    MessageBox.Show("Raio deve ser maior que zero!");
                txtRaio.Focus();
            }
        }

        private void txtAltura_Validated(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnFechar)
                return;


            if (!double.TryParse(txtAltura.Text, out altura))
            {
                MessageBox.Show("Altura Inválido!");
                txtAltura.Focus();
            }
            else
            {
                if (altura <= 0)

                    MessageBox.Show("Altura deve ser maior que zero!");
                txtAltura.Focus();
            }

        }

        private void txtVolume_TextChanged(object sender, EventArgs e)
        {
            volume = Math.PI * Math.Pow(raio, 2) * altura;
            txtVolume.Text = volume.ToString("N2");
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtRaio.Text = "";
            txtVolume.Text = String.Empty;

            raio = 0;
            altura = 0;
            volume = 0;
        }
    }
}



