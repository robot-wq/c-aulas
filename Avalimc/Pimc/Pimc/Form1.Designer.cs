namespace Pimc
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
            this.lbl_PesoAtual = new System.Windows.Forms.Label();
            this.lbl_Altura = new System.Windows.Forms.Label();
            this.lbl_Imc = new System.Windows.Forms.Label();
            this.mskbox_PesoAtual = new System.Windows.Forms.MaskedTextBox();
            this.mskbox_Altura = new System.Windows.Forms.MaskedTextBox();
            this.txtbox_Imc = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.txt_Mensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_PesoAtual
            // 
            this.lbl_PesoAtual.AutoSize = true;
            this.lbl_PesoAtual.Location = new System.Drawing.Point(151, 58);
            this.lbl_PesoAtual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PesoAtual.Name = "lbl_PesoAtual";
            this.lbl_PesoAtual.Size = new System.Drawing.Size(107, 25);
            this.lbl_PesoAtual.TabIndex = 0;
            this.lbl_PesoAtual.Text = "Peso Atual";
            // 
            // lbl_Altura
            // 
            this.lbl_Altura.AutoSize = true;
            this.lbl_Altura.Location = new System.Drawing.Point(151, 120);
            this.lbl_Altura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Altura.Name = "lbl_Altura";
            this.lbl_Altura.Size = new System.Drawing.Size(63, 25);
            this.lbl_Altura.TabIndex = 1;
            this.lbl_Altura.Text = "Altura";
            // 
            // lbl_Imc
            // 
            this.lbl_Imc.AutoSize = true;
            this.lbl_Imc.Location = new System.Drawing.Point(151, 186);
            this.lbl_Imc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Imc.Name = "lbl_Imc";
            this.lbl_Imc.Size = new System.Drawing.Size(49, 25);
            this.lbl_Imc.TabIndex = 2;
            this.lbl_Imc.Text = "IMC";
            // 
            // mskbox_PesoAtual
            // 
            this.mskbox_PesoAtual.Location = new System.Drawing.Point(330, 58);
            this.mskbox_PesoAtual.Mask = "999,99";
            this.mskbox_PesoAtual.Name = "mskbox_PesoAtual";
            this.mskbox_PesoAtual.Size = new System.Drawing.Size(174, 30);
            this.mskbox_PesoAtual.TabIndex = 3;
            this.mskbox_PesoAtual.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbox_PesoAtual_KeyPress);
            this.mskbox_PesoAtual.Validated += new System.EventHandler(this.mskbox_PesoAtual_Validated);
            // 
            // mskbox_Altura
            // 
            this.mskbox_Altura.Location = new System.Drawing.Point(330, 120);
            this.mskbox_Altura.Mask = "9,99";
            this.mskbox_Altura.Name = "mskbox_Altura";
            this.mskbox_Altura.Size = new System.Drawing.Size(174, 30);
            this.mskbox_Altura.TabIndex = 4;
            this.mskbox_Altura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskbox_Altura_KeyPress);
            this.mskbox_Altura.Validated += new System.EventHandler(this.mskbox_Altura_Validated);
            // 
            // txtbox_Imc
            // 
            this.txtbox_Imc.Location = new System.Drawing.Point(330, 186);
            this.txtbox_Imc.Name = "txtbox_Imc";
            this.txtbox_Imc.ReadOnly = true;
            this.txtbox_Imc.Size = new System.Drawing.Size(174, 30);
            this.txtbox_Imc.TabIndex = 5;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(156, 311);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(167, 49);
            this.btn_Calcular.TabIndex = 6;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(366, 311);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(152, 49);
            this.btn_Limpar.TabIndex = 7;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(556, 311);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(146, 49);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // txt_Mensagem
            // 
            this.txt_Mensagem.Location = new System.Drawing.Point(602, 120);
            this.txt_Mensagem.Name = "txt_Mensagem";
            this.txt_Mensagem.ReadOnly = true;
            this.txt_Mensagem.Size = new System.Drawing.Size(163, 30);
            this.txt_Mensagem.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.txt_Mensagem);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txtbox_Imc);
            this.Controls.Add(this.mskbox_Altura);
            this.Controls.Add(this.mskbox_PesoAtual);
            this.Controls.Add(this.lbl_Imc);
            this.Controls.Add(this.lbl_Altura);
            this.Controls.Add(this.lbl_PesoAtual);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PesoAtual;
        private System.Windows.Forms.Label lbl_Altura;
        private System.Windows.Forms.Label lbl_Imc;
        private System.Windows.Forms.MaskedTextBox mskbox_PesoAtual;
        private System.Windows.Forms.MaskedTextBox mskbox_Altura;
        private System.Windows.Forms.TextBox txtbox_Imc;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.TextBox txt_Mensagem;
    }
}

