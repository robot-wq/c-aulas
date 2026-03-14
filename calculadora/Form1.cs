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

namespace exercicio_nota
{
    public partial class Form1 : Form
    {

        Double Numero1;
        Double Numero2;
        Double Resultado;

        public Form1()
        {
            InitializeComponent();
        }

        public object Return { get; private set; }

        private void txtNumero1_Validated(object sender, EventArgs e)
        {

            if (this.ActiveControl == btnsair)
            { return; }

            if (!Double.TryParse(txtNumero1.Text, out Numero1))
            {
                MessageBox.Show("Numero1 invalido!");
                txtNumero1.Focus();
            }
        }

        private void txtNumero2_Validated(object sender, EventArgs e)
        {
            if (this.ActiveControl == btnsair)
            { return; }

            if (!Double.TryParse(txtNumero2.Text, out Numero2))
            {
                MessageBox.Show("Numero2 invalido!");
                txtNumero2.Focus();
            }
        }

        private void btnlimpa_Validated(object sender, EventArgs e)
        {
            txtNumero1.Clear();
            txtNumero2.Text = "";
            txtResultado.Text = String.Empty;

            Numero1 = 0;
            Numero2 = 0;
            Resultado = 0;
        }

        private void btnsair_Validated(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSomar_Validated(object sender, EventArgs e)
        {
            Resultado = Numero1 + Numero2;
            txtResultado.Text = Resultado.ToString();
        }

        private void btnMenos_Validated(object sender, EventArgs e)
        {
            Resultado = Numero1 - Numero2;
            txtResultado.Text = Resultado.ToString();
        }

        private void btnmultiplicação_Validated(object sender, EventArgs e)
        {
            Resultado = Numero1 * Numero2;
            txtResultado.Text = Resultado.ToString();
        }

        private void btnDivisão_Validated(object sender, EventArgs e)
        {
            if (Numero2 == 0)
            {
                MessageBox.Show("Numero2 não pode ser zero");
                txtNumero2.Focus();
            }
            else { 
                Resultado = Numero1 / Numero2;
            txtResultado.Text = Resultado.ToString(); }
        }
            
        }
    }

