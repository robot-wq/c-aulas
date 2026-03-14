namespace exercicio_nota
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnlimpa = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnmultiplicação = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnDivisão = new System.Windows.Forms.Button();
            this.lblnumero1 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblnumero2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(205, 104);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(184, 26);
            this.txtNumero2.TabIndex = 0;
            this.txtNumero2.Validated += new System.EventHandler(this.txtNumero2_Validated);
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(205, 0);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(184, 26);
            this.txtNumero1.TabIndex = 1;
            this.txtNumero1.Validated += new System.EventHandler(this.txtNumero1_Validated);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(205, 200);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(184, 26);
            this.txtResultado.TabIndex = 2;
            // 
            // btnlimpa
            // 
            this.btnlimpa.Location = new System.Drawing.Point(450, 3);
            this.btnlimpa.Name = "btnlimpa";
            this.btnlimpa.Size = new System.Drawing.Size(118, 54);
            this.btnlimpa.TabIndex = 3;
            this.btnlimpa.Text = "limpar";
            this.btnlimpa.UseVisualStyleBackColor = true;
            this.btnlimpa.Validated += new System.EventHandler(this.btnlimpa_Validated);
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(450, 88);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(118, 58);
            this.btnsair.TabIndex = 4;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Validated += new System.EventHandler(this.btnsair_Validated);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(12, 270);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(88, 48);
            this.btnSomar.TabIndex = 5;
            this.btnSomar.Text = "+";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Validated += new System.EventHandler(this.btnSomar_Validated);
            // 
            // btnmultiplicação
            // 
            this.btnmultiplicação.Location = new System.Drawing.Point(301, 270);
            this.btnmultiplicação.Name = "btnmultiplicação";
            this.btnmultiplicação.Size = new System.Drawing.Size(88, 48);
            this.btnmultiplicação.TabIndex = 7;
            this.btnmultiplicação.Text = "*";
            this.btnmultiplicação.UseVisualStyleBackColor = true;
            this.btnmultiplicação.Validated += new System.EventHandler(this.btnmultiplicação_Validated);
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(144, 270);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(102, 48);
            this.btnMenos.TabIndex = 8;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            this.btnMenos.Validated += new System.EventHandler(this.btnMenos_Validated);
            // 
            // btnDivisão
            // 
            this.btnDivisão.Location = new System.Drawing.Point(480, 270);
            this.btnDivisão.Name = "btnDivisão";
            this.btnDivisão.Size = new System.Drawing.Size(88, 48);
            this.btnDivisão.TabIndex = 9;
            this.btnDivisão.Text = "/";
            this.btnDivisão.UseVisualStyleBackColor = true;
            this.btnDivisão.Validated += new System.EventHandler(this.btnDivisão_Validated);
            // 
            // lblnumero1
            // 
            this.lblnumero1.AutoSize = true;
            this.lblnumero1.Location = new System.Drawing.Point(-1, 0);
            this.lblnumero1.Name = "lblnumero1";
            this.lblnumero1.Size = new System.Drawing.Size(78, 20);
            this.lblnumero1.TabIndex = 10;
            this.lblnumero1.Text = "Numero 1";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(-1, 206);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(82, 20);
            this.lblResultado.TabIndex = 11;
            this.lblResultado.Text = "Resultado";
            // 
            // lblnumero2
            // 
            this.lblnumero2.AutoSize = true;
            this.lblnumero2.Location = new System.Drawing.Point(-1, 107);
            this.lblnumero2.Name = "lblnumero2";
            this.lblnumero2.Size = new System.Drawing.Size(78, 20);
            this.lblnumero2.TabIndex = 12;
            this.lblnumero2.Text = "Numero 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 624);
            this.Controls.Add(this.lblnumero2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblnumero1);
            this.Controls.Add(this.btnDivisão);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnmultiplicação);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpa);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.txtNumero2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnlimpa;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnmultiplicação;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnDivisão;
        private System.Windows.Forms.Label lblnumero1;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblnumero2;
    }
}

