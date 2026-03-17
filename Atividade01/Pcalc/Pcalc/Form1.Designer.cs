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
            this.lblprimeiroNumero = new System.Windows.Forms.Label();
            this.lblsegundoNumero = new System.Windows.Forms.Label();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txtprimeiroNumeroD = new System.Windows.Forms.TextBox();
            this.txtsegundoNumeroD = new System.Windows.Forms.TextBox();
            this.txtresultadoD = new System.Windows.Forms.TextBox();
            this.btnbotaoLimpar = new System.Windows.Forms.Button();
            this.btnbotaoSair = new System.Windows.Forms.Button();
            this.btnbotaoSoma = new System.Windows.Forms.Button();
            this.btnbotaoSubtrai = new System.Windows.Forms.Button();
            this.btnbotaoMultiplica = new System.Windows.Forms.Button();
            this.btnbotaoDividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblprimeiroNumero
            // 
            this.lblprimeiroNumero.AutoSize = true;
            this.lblprimeiroNumero.Location = new System.Drawing.Point(47, 75);
            this.lblprimeiroNumero.Name = "lblprimeiroNumero";
            this.lblprimeiroNumero.Size = new System.Drawing.Size(82, 20);
            this.lblprimeiroNumero.TabIndex = 0;
            this.lblprimeiroNumero.Text = "Número 1:";
            // 
            // lblsegundoNumero
            // 
            this.lblsegundoNumero.AutoSize = true;
            this.lblsegundoNumero.Location = new System.Drawing.Point(47, 144);
            this.lblsegundoNumero.Name = "lblsegundoNumero";
            this.lblsegundoNumero.Size = new System.Drawing.Size(82, 20);
            this.lblsegundoNumero.TabIndex = 1;
            this.lblsegundoNumero.Text = "Número 2:";
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(39, 220);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(90, 20);
            this.lblresultado.TabIndex = 2;
            this.lblresultado.Text = "Resultado :";
            // 
            // txtprimeiroNumeroD
            // 
            this.txtprimeiroNumeroD.Location = new System.Drawing.Point(167, 72);
            this.txtprimeiroNumeroD.Name = "txtprimeiroNumeroD";
            this.txtprimeiroNumeroD.Size = new System.Drawing.Size(267, 26);
            this.txtprimeiroNumeroD.TabIndex = 3;
            this.txtprimeiroNumeroD.TextChanged += new System.EventHandler(this.txtprimeiroNumeroD_TextChanged);
            this.txtprimeiroNumeroD.Validating += new System.ComponentModel.CancelEventHandler(this.txtprimeiroNumeroD_Validating);
            // 
            // txtsegundoNumeroD
            // 
            this.txtsegundoNumeroD.Location = new System.Drawing.Point(167, 144);
            this.txtsegundoNumeroD.Name = "txtsegundoNumeroD";
            this.txtsegundoNumeroD.Size = new System.Drawing.Size(267, 26);
            this.txtsegundoNumeroD.TabIndex = 4;
            this.txtsegundoNumeroD.TextChanged += new System.EventHandler(this.txtsegundoNumeroD_TextChanged);
            // 
            // txtresultadoD
            // 
            this.txtresultadoD.Enabled = false;
            this.txtresultadoD.Location = new System.Drawing.Point(167, 217);
            this.txtresultadoD.Name = "txtresultadoD";
            this.txtresultadoD.Size = new System.Drawing.Size(267, 26);
            this.txtresultadoD.TabIndex = 5;
            this.txtresultadoD.TextChanged += new System.EventHandler(this.txtresultadoD_TextChanged);
            // 
            // btnbotaoLimpar
            // 
            this.btnbotaoLimpar.Location = new System.Drawing.Point(581, 72);
            this.btnbotaoLimpar.Name = "btnbotaoLimpar";
            this.btnbotaoLimpar.Size = new System.Drawing.Size(137, 73);
            this.btnbotaoLimpar.TabIndex = 6;
            this.btnbotaoLimpar.Text = "Limpar";
            this.btnbotaoLimpar.UseVisualStyleBackColor = true;
            this.btnbotaoLimpar.Click += new System.EventHandler(this.btnbotaoLimpar_Click);
            // 
            // btnbotaoSair
            // 
            this.btnbotaoSair.Location = new System.Drawing.Point(581, 194);
            this.btnbotaoSair.Name = "btnbotaoSair";
            this.btnbotaoSair.Size = new System.Drawing.Size(137, 73);
            this.btnbotaoSair.TabIndex = 7;
            this.btnbotaoSair.Text = "Sair";
            this.btnbotaoSair.UseVisualStyleBackColor = true;
            this.btnbotaoSair.Click += new System.EventHandler(this.btnbotaoSair_Click);
            // 
            // btnbotaoSoma
            // 
            this.btnbotaoSoma.Location = new System.Drawing.Point(65, 337);
            this.btnbotaoSoma.Name = "btnbotaoSoma";
            this.btnbotaoSoma.Size = new System.Drawing.Size(135, 80);
            this.btnbotaoSoma.TabIndex = 8;
            this.btnbotaoSoma.Text = "+";
            this.btnbotaoSoma.UseVisualStyleBackColor = true;
            this.btnbotaoSoma.Click += new System.EventHandler(this.btnbotaoSoma_Click);
            // 
            // btnbotaoSubtrai
            // 
            this.btnbotaoSubtrai.Location = new System.Drawing.Point(235, 337);
            this.btnbotaoSubtrai.Name = "btnbotaoSubtrai";
            this.btnbotaoSubtrai.Size = new System.Drawing.Size(130, 81);
            this.btnbotaoSubtrai.TabIndex = 9;
            this.btnbotaoSubtrai.Text = "-";
            this.btnbotaoSubtrai.UseVisualStyleBackColor = true;
            this.btnbotaoSubtrai.Click += new System.EventHandler(this.btnbotaoSubtrai_Click);
            // 
            // btnbotaoMultiplica
            // 
            this.btnbotaoMultiplica.Location = new System.Drawing.Point(393, 338);
            this.btnbotaoMultiplica.Name = "btnbotaoMultiplica";
            this.btnbotaoMultiplica.Size = new System.Drawing.Size(135, 80);
            this.btnbotaoMultiplica.TabIndex = 10;
            this.btnbotaoMultiplica.Text = "*";
            this.btnbotaoMultiplica.UseVisualStyleBackColor = true;
            this.btnbotaoMultiplica.Click += new System.EventHandler(this.btnbotaoMultiplica_Click);
            // 
            // btnbotaoDividir
            // 
            this.btnbotaoDividir.Location = new System.Drawing.Point(572, 337);
            this.btnbotaoDividir.Name = "btnbotaoDividir";
            this.btnbotaoDividir.Size = new System.Drawing.Size(146, 81);
            this.btnbotaoDividir.TabIndex = 11;
            this.btnbotaoDividir.Text = "/";
            this.btnbotaoDividir.UseVisualStyleBackColor = true;
            this.btnbotaoDividir.Click += new System.EventHandler(this.btnbotaoDividir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbotaoDividir);
            this.Controls.Add(this.btnbotaoMultiplica);
            this.Controls.Add(this.btnbotaoSubtrai);
            this.Controls.Add(this.btnbotaoSoma);
            this.Controls.Add(this.btnbotaoSair);
            this.Controls.Add(this.btnbotaoLimpar);
            this.Controls.Add(this.txtresultadoD);
            this.Controls.Add(this.txtsegundoNumeroD);
            this.Controls.Add(this.txtprimeiroNumeroD);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.lblsegundoNumero);
            this.Controls.Add(this.lblprimeiroNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprimeiroNumero;
        private System.Windows.Forms.Label lblsegundoNumero;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txtprimeiroNumeroD;
        private System.Windows.Forms.TextBox txtsegundoNumeroD;
        private System.Windows.Forms.TextBox txtresultadoD;
        private System.Windows.Forms.Button btnbotaoLimpar;
        private System.Windows.Forms.Button btnbotaoSair;
        private System.Windows.Forms.Button btnbotaoSoma;
        private System.Windows.Forms.Button btnbotaoSubtrai;
        private System.Windows.Forms.Button btnbotaoMultiplica;
        private System.Windows.Forms.Button btnbotaoDividir;
    }
}

