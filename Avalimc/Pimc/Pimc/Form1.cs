using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        double peso;
        double altura;
        double imc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mskbox_PesoAtual_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite apenas números e teclas de controle
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void mskbox_Altura_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite números, vírgula ou ponto
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void mskbox_PesoAtual_Validated(object sender, EventArgs e)
        {
            double.TryParse(mskbox_PesoAtual.Text, out peso);
        }

        private void mskbox_Altura_Validated(object sender, EventArgs e)
        {
            double.TryParse(mskbox_Altura.Text, out altura);
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {

            imc = (peso / (altura * altura)) * 100;
            txtbox_Imc.Text = imc.ToString("F2");

            if (imc < 18.5)
            {
                txt_Mensagem.Text = "Extrema Magreza";
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                txt_Mensagem.Text = "Normal";
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                txt_Mensagem.Text = "Sobrepeso";
            }
            else if (imc >= 30 && imc <= 39.9)
            {
                txt_Mensagem.Text = "Obesidade";
            }
            else if (imc >= 40) {
                txt_Mensagem.Text = "Extrema Obesidade";
            }
        }
            

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            mskbox_Altura.Clear();
            mskbox_PesoAtual.Clear();
            txtbox_Imc.Clear();

            mskbox_PesoAtual.Focus();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}