namespace WFAExercicio05
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbDiferenca = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.rbOrdem = new System.Windows.Forms.RadioButton();
            this.rbMenor = new System.Windows.Forms.RadioButton();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApresentar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número 01:";
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(28, 54);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(79, 22);
            this.txtN1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDiferenca);
            this.groupBox1.Controls.Add(this.rbMedia);
            this.groupBox1.Controls.Add(this.rbOrdem);
            this.groupBox1.Controls.Add(this.rbMenor);
            this.groupBox1.Location = new System.Drawing.Point(28, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbDiferenca
            // 
            this.rbDiferenca.AutoSize = true;
            this.rbDiferenca.Location = new System.Drawing.Point(25, 169);
            this.rbDiferenca.Name = "rbDiferenca";
            this.rbDiferenca.Size = new System.Drawing.Size(246, 21);
            this.rbDiferenca.TabIndex = 3;
            this.rbDiferenca.TabStop = true;
            this.rbDiferenca.Text = "Diferença entre o maior e o menor";
            this.rbDiferenca.UseVisualStyleBackColor = true;
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Location = new System.Drawing.Point(25, 127);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(135, 21);
            this.rbMedia.TabIndex = 2;
            this.rbMedia.TabStop = true;
            this.rbMedia.Text = "Média aritimética";
            this.rbMedia.UseVisualStyleBackColor = true;
            // 
            // rbOrdem
            // 
            this.rbOrdem.AutoSize = true;
            this.rbOrdem.Location = new System.Drawing.Point(25, 82);
            this.rbOrdem.Name = "rbOrdem";
            this.rbOrdem.Size = new System.Drawing.Size(138, 21);
            this.rbOrdem.TabIndex = 1;
            this.rbOrdem.TabStop = true;
            this.rbOrdem.Text = "Ordem crescente";
            this.rbOrdem.UseVisualStyleBackColor = true;
            // 
            // rbMenor
            // 
            this.rbMenor.AutoSize = true;
            this.rbMenor.Location = new System.Drawing.Point(25, 39);
            this.rbMenor.Name = "rbMenor";
            this.rbMenor.Size = new System.Drawing.Size(121, 21);
            this.rbMenor.TabIndex = 0;
            this.rbMenor.TabStop = true;
            this.rbMenor.Text = "Menor número";
            this.rbMenor.UseVisualStyleBackColor = true;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(135, 54);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(79, 22);
            this.txtN2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 02:";
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(241, 54);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(79, 22);
            this.txtN3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número 03:";
            // 
            // btnApresentar
            // 
            this.btnApresentar.Location = new System.Drawing.Point(28, 357);
            this.btnApresentar.Name = "btnApresentar";
            this.btnApresentar.Size = new System.Drawing.Size(292, 27);
            this.btnApresentar.TabIndex = 7;
            this.btnApresentar.Text = "Apresentar";
            this.btnApresentar.UseVisualStyleBackColor = true;
            this.btnApresentar.Click += new System.EventHandler(this.btnApresentar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(244, 471);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 27);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(28, 429);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(292, 22);
            this.txtResultado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 406);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(31, 471);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 27);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 521);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnApresentar);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Números";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbDiferenca;
        private System.Windows.Forms.RadioButton rbMedia;
        private System.Windows.Forms.RadioButton rbOrdem;
        private System.Windows.Forms.RadioButton rbMenor;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApresentar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLimpar;
    }
}

