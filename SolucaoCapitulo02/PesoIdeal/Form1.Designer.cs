namespace PesoIdeal
{
    partial class CalcPesoideal
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
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnFeminino = new System.Windows.Forms.RadioButton();
            this.rbnMasculino = new System.Windows.Forms.RadioButton();
            this.rbnSelecionado = new System.Windows.Forms.GroupBox();
            this.lblvaluepesoideal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rbnSelecionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(164, 26);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(60, 20);
            this.txtAltura.TabIndex = 4;
            this.txtAltura.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Peso Ideal";
            // 
            // rbnFeminino
            // 
            this.rbnFeminino.AutoSize = true;
            this.rbnFeminino.Location = new System.Drawing.Point(86, 16);
            this.rbnFeminino.Name = "rbnFeminino";
            this.rbnFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbnFeminino.TabIndex = 1;
            this.rbnFeminino.TabStop = true;
            this.rbnFeminino.Tag = "rbnSelecionado ";
            this.rbnFeminino.Text = "Feminino";
            this.rbnFeminino.UseVisualStyleBackColor = true;
            this.rbnFeminino.CheckedChanged += new System.EventHandler(this.rbnFeminino_CheckedChanged);
            // 
            // rbnMasculino
            // 
            this.rbnMasculino.AutoSize = true;
            this.rbnMasculino.Location = new System.Drawing.Point(7, 16);
            this.rbnMasculino.Name = "rbnMasculino";
            this.rbnMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbnMasculino.TabIndex = 0;
            this.rbnMasculino.TabStop = true;
            this.rbnMasculino.Tag = "rbnSelecionado";
            this.rbnMasculino.Text = "Masculino";
            this.rbnMasculino.UseVisualStyleBackColor = true;
            this.rbnMasculino.CheckedChanged += new System.EventHandler(this.rbnMasculino_CheckedChanged);
            // 
            // rbnSelecionado
            // 
            this.rbnSelecionado.Controls.Add(this.rbnMasculino);
            this.rbnSelecionado.Controls.Add(this.rbnFeminino);
            this.rbnSelecionado.Location = new System.Drawing.Point(0, 9);
            this.rbnSelecionado.Name = "rbnSelecionado";
            this.rbnSelecionado.Size = new System.Drawing.Size(160, 44);
            this.rbnSelecionado.TabIndex = 6;
            this.rbnSelecionado.TabStop = false;
            this.rbnSelecionado.Text = "Sexo";
            // 
            // lblvaluepesoideal
            // 
            this.lblvaluepesoideal.AutoSize = true;
            this.lblvaluepesoideal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblvaluepesoideal.ForeColor = System.Drawing.Color.Red;
            this.lblvaluepesoideal.Location = new System.Drawing.Point(138, 74);
            this.lblvaluepesoideal.Name = "lblvaluepesoideal";
            this.lblvaluepesoideal.Size = new System.Drawing.Size(20, 24);
            this.lblvaluepesoideal.TabIndex = 7;
            this.lblvaluepesoideal.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CalcPesoideal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 108);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblvaluepesoideal);
            this.Controls.Add(this.rbnSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.label2);
            this.Name = "CalcPesoideal";
            this.Text = "Cálculo peso ideal";
            this.Load += new System.EventHandler(this.CalcPesoideal_Load);
            this.rbnSelecionado.ResumeLayout(false);
            this.rbnSelecionado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnFeminino;
        private System.Windows.Forms.RadioButton rbnMasculino;
        private System.Windows.Forms.GroupBox rbnSelecionado;
        private System.Windows.Forms.Label lblvaluepesoideal;
        private System.Windows.Forms.Button button1;
    }
}

