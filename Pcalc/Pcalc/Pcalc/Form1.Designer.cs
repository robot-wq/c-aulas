namespace Pcalc
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
            this.lbl_Num1 = new System.Windows.Forms.Label();
            this.lbl_Num2 = new System.Windows.Forms.Label();
            this.lbl_Resultado = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Adicao = new System.Windows.Forms.Button();
            this.btn_Subtracao = new System.Windows.Forms.Button();
            this.btn_Multiplicacao = new System.Windows.Forms.Button();
            this.btn_Divisao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Num1
            // 
            this.lbl_Num1.AutoSize = true;
            this.lbl_Num1.Location = new System.Drawing.Point(97, 41);
            this.lbl_Num1.Name = "lbl_Num1";
            this.lbl_Num1.Size = new System.Drawing.Size(97, 25);
            this.lbl_Num1.TabIndex = 0;
            this.lbl_Num1.Text = "Numero 1";
            // 
            // lbl_Num2
            // 
            this.lbl_Num2.AutoSize = true;
            this.lbl_Num2.Location = new System.Drawing.Point(97, 122);
            this.lbl_Num2.Name = "lbl_Num2";
            this.lbl_Num2.Size = new System.Drawing.Size(97, 25);
            this.lbl_Num2.TabIndex = 1;
            this.lbl_Num2.Text = "Numero 2";
            // 
            // lbl_Resultado
            // 
            this.lbl_Resultado.AutoSize = true;
            this.lbl_Resultado.Location = new System.Drawing.Point(97, 204);
            this.lbl_Resultado.Name = "lbl_Resultado";
            this.lbl_Resultado.Size = new System.Drawing.Size(99, 25);
            this.lbl_Resultado.TabIndex = 2;
            this.lbl_Resultado.Text = "Resultado";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Location = new System.Drawing.Point(274, 41);
            this.txt_Num1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(423, 30);
            this.txt_Num1.TabIndex = 3;
            this.txt_Num1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num1_KeyPress);
            this.txt_Num1.Validated += new System.EventHandler(this.txt_Num1_Validated);
            // 
            // txt_Num2
            // 
            this.txt_Num2.Location = new System.Drawing.Point(274, 122);
            this.txt_Num2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(423, 30);
            this.txt_Num2.TabIndex = 4;
            this.txt_Num2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Num2_KeyPress);
            this.txt_Num2.Validated += new System.EventHandler(this.txt_Num2_Validated);
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(274, 204);
            this.txt_Resultado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.ReadOnly = true;
            this.txt_Resultado.Size = new System.Drawing.Size(423, 30);
            this.txt_Resultado.TabIndex = 5;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(856, 41);
            this.btn_Limpar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(219, 92);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.Location = new System.Drawing.Point(856, 173);
            this.btn_Sair.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(219, 92);
            this.btn_Sair.TabIndex = 7;
            this.btn_Sair.Text = "sair";
            this.btn_Sair.UseVisualStyleBackColor = true;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Adicao
            // 
            this.btn_Adicao.Location = new System.Drawing.Point(36, 406);
            this.btn_Adicao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Adicao.Name = "btn_Adicao";
            this.btn_Adicao.Size = new System.Drawing.Size(219, 92);
            this.btn_Adicao.TabIndex = 8;
            this.btn_Adicao.Text = "+";
            this.btn_Adicao.UseVisualStyleBackColor = true;
            this.btn_Adicao.Click += new System.EventHandler(this.btn_Adicao_Click);
            // 
            // btn_Subtracao
            // 
            this.btn_Subtracao.Location = new System.Drawing.Point(335, 406);
            this.btn_Subtracao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Subtracao.Name = "btn_Subtracao";
            this.btn_Subtracao.Size = new System.Drawing.Size(219, 92);
            this.btn_Subtracao.TabIndex = 9;
            this.btn_Subtracao.Text = "-";
            this.btn_Subtracao.UseVisualStyleBackColor = true;
            this.btn_Subtracao.Click += new System.EventHandler(this.btn_Subtracao_Click);
            // 
            // btn_Multiplicacao
            // 
            this.btn_Multiplicacao.Location = new System.Drawing.Point(643, 406);
            this.btn_Multiplicacao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Multiplicacao.Name = "btn_Multiplicacao";
            this.btn_Multiplicacao.Size = new System.Drawing.Size(219, 92);
            this.btn_Multiplicacao.TabIndex = 10;
            this.btn_Multiplicacao.Text = "*";
            this.btn_Multiplicacao.UseVisualStyleBackColor = true;
            this.btn_Multiplicacao.Click += new System.EventHandler(this.btn_Multiplicacao_Click);
            // 
            // btn_Divisao
            // 
            this.btn_Divisao.Location = new System.Drawing.Point(930, 406);
            this.btn_Divisao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Divisao.Name = "btn_Divisao";
            this.btn_Divisao.Size = new System.Drawing.Size(219, 92);
            this.btn_Divisao.TabIndex = 11;
            this.btn_Divisao.Text = "/";
            this.btn_Divisao.UseVisualStyleBackColor = true;
            this.btn_Divisao.Click += new System.EventHandler(this.btn_Divisao_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 709);
            this.Controls.Add(this.btn_Divisao);
            this.Controls.Add(this.btn_Multiplicacao);
            this.Controls.Add(this.btn_Subtracao);
            this.Controls.Add(this.btn_Adicao);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_Resultado);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.lbl_Resultado);
            this.Controls.Add(this.lbl_Num2);
            this.Controls.Add(this.lbl_Num1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Num1;
        private System.Windows.Forms.Label lbl_Num2;
        private System.Windows.Forms.Label lbl_Resultado;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Button btn_Adicao;
        private System.Windows.Forms.Button btn_Subtracao;
        private System.Windows.Forms.Button btn_Multiplicacao;
        private System.Windows.Forms.Button btn_Divisao;
    }
}

