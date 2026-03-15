using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pcalc
{ 
    public partial class Form1 : Form
    {
        double n1, n2, resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_Num1.Clear();
            txt_Num2.Clear();
            txt_Resultado.Clear();
        }

        private void txt_Num1_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txt_Num2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
        && (e.KeyChar != '.') && (e.KeyChar != '-'))
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;

        }

        private void txt_Num2_Validated(object sender, EventArgs e)
        {
            n2 = Convert.ToDouble(txt_Num2.Text);
        }

        private void btn_Adicao_Click(object sender, EventArgs e)
        {
            resultado = n1 + n2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            resultado = n1 - n2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            resultado = n1 * n2;
            txt_Resultado.Text = resultado.ToString();
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            if (txt_Num1.Text == "0" || txt_Num2.Text == "0")
            {
                MessageBox.Show("Divisão por 0 não é permitida!");
            }
            else {
                resultado = n1 / n2;
                txt_Resultado.Text = resultado.ToString();
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Num1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar))
        && (e.KeyChar != '.') && (e.KeyChar != '-'))
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;

            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;

        }

        private void txt_Num1_Validated(object sender, EventArgs e)
        {
            n1 = Convert.ToDouble(txt_Num1.Text);
           // MessageBox.Show("Valor Convertido para double");
        }
    }
}
