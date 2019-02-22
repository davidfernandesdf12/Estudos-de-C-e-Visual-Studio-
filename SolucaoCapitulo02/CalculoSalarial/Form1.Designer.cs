namespace CalculoSalarial
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
            this.groupTurno = new System.Windows.Forms.GroupBox();
            this.rdoMatutino = new System.Windows.Forms.RadioButton();
            this.rdoVespetino = new System.Windows.Forms.RadioButton();
            this.rdoNoturno = new System.Windows.Forms.RadioButton();
            this.txtSalarioMin = new System.Windows.Forms.TextBox();
            this.txtHorasTrab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupCategoria = new System.Windows.Forms.GroupBox();
            this.rdoCalouro = new System.Windows.Forms.RadioButton();
            this.rdoVeterano = new System.Windows.Forms.RadioButton();
            this.lbxResumo = new System.Windows.Forms.ListBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupTurno.SuspendLayout();
            this.groupCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTurno
            // 
            this.groupTurno.Controls.Add(this.rdoMatutino);
            this.groupTurno.Controls.Add(this.rdoVespetino);
            this.groupTurno.Controls.Add(this.rdoNoturno);
            this.groupTurno.Location = new System.Drawing.Point(209, 4);
            this.groupTurno.Name = "groupTurno";
            this.groupTurno.Size = new System.Drawing.Size(109, 96);
            this.groupTurno.TabIndex = 0;
            this.groupTurno.TabStop = false;
            this.groupTurno.Text = "Turno";
            // 
            // rdoMatutino
            // 
            this.rdoMatutino.AutoSize = true;
            this.rdoMatutino.Location = new System.Drawing.Point(13, 17);
            this.rdoMatutino.Name = "rdoMatutino";
            this.rdoMatutino.Size = new System.Drawing.Size(66, 17);
            this.rdoMatutino.TabIndex = 8;
            this.rdoMatutino.TabStop = true;
            this.rdoMatutino.Text = "Matutino";
            this.rdoMatutino.UseVisualStyleBackColor = true;
            // 
            // rdoVespetino
            // 
            this.rdoVespetino.AutoSize = true;
            this.rdoVespetino.Location = new System.Drawing.Point(13, 40);
            this.rdoVespetino.Name = "rdoVespetino";
            this.rdoVespetino.Size = new System.Drawing.Size(75, 17);
            this.rdoVespetino.TabIndex = 9;
            this.rdoVespetino.TabStop = true;
            this.rdoVespetino.Text = "Vespertino";
            this.rdoVespetino.UseVisualStyleBackColor = true;
            // 
            // rdoNoturno
            // 
            this.rdoNoturno.AutoSize = true;
            this.rdoNoturno.Location = new System.Drawing.Point(13, 63);
            this.rdoNoturno.Name = "rdoNoturno";
            this.rdoNoturno.Size = new System.Drawing.Size(63, 17);
            this.rdoNoturno.TabIndex = 10;
            this.rdoNoturno.TabStop = true;
            this.rdoNoturno.Text = "Noturno";
            this.rdoNoturno.UseVisualStyleBackColor = true;
            // 
            // txtSalarioMin
            // 
            this.txtSalarioMin.Location = new System.Drawing.Point(103, 12);
            this.txtSalarioMin.Name = "txtSalarioMin";
            this.txtSalarioMin.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioMin.TabIndex = 1;
            // 
            // txtHorasTrab
            // 
            this.txtHorasTrab.Location = new System.Drawing.Point(103, 38);
            this.txtHorasTrab.Name = "txtHorasTrab";
            this.txtHorasTrab.Size = new System.Drawing.Size(100, 20);
            this.txtHorasTrab.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Horas Trabalhadas:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Salario Minímo:";
            // 
            // groupCategoria
            // 
            this.groupCategoria.Controls.Add(this.rdoCalouro);
            this.groupCategoria.Controls.Add(this.rdoVeterano);
            this.groupCategoria.Location = new System.Drawing.Point(7, 64);
            this.groupCategoria.Name = "groupCategoria";
            this.groupCategoria.Size = new System.Drawing.Size(196, 36);
            this.groupCategoria.TabIndex = 5;
            this.groupCategoria.TabStop = false;
            this.groupCategoria.Text = "Categoria";
            // 
            // rdoCalouro
            // 
            this.rdoCalouro.AutoSize = true;
            this.rdoCalouro.Location = new System.Drawing.Point(12, 13);
            this.rdoCalouro.Name = "rdoCalouro";
            this.rdoCalouro.Size = new System.Drawing.Size(61, 17);
            this.rdoCalouro.TabIndex = 6;
            this.rdoCalouro.TabStop = true;
            this.rdoCalouro.Text = "Calouro";
            this.rdoCalouro.UseVisualStyleBackColor = true;
            // 
            // rdoVeterano
            // 
            this.rdoVeterano.AutoSize = true;
            this.rdoVeterano.Location = new System.Drawing.Point(105, 13);
            this.rdoVeterano.Name = "rdoVeterano";
            this.rdoVeterano.Size = new System.Drawing.Size(68, 17);
            this.rdoVeterano.TabIndex = 7;
            this.rdoVeterano.TabStop = true;
            this.rdoVeterano.Text = "Veterano";
            this.rdoVeterano.UseVisualStyleBackColor = true;
            // 
            // lbxResumo
            // 
            this.lbxResumo.FormattingEnabled = true;
            this.lbxResumo.Location = new System.Drawing.Point(12, 106);
            this.lbxResumo.Name = "lbxResumo";
            this.lbxResumo.Size = new System.Drawing.Size(306, 82);
            this.lbxResumo.TabIndex = 6;
            // 
            // lblSituacao
            // 
            this.lblSituacao.BackColor = System.Drawing.Color.Yellow;
            this.lblSituacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSituacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSituacao.ForeColor = System.Drawing.Color.Blue;
            this.lblSituacao.Location = new System.Drawing.Point(12, 195);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(200, 20);
            this.lblSituacao.TabIndex = 17;
            this.lblSituacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblSituacao);
            this.Controls.Add(this.lbxResumo);
            this.Controls.Add(this.groupCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHorasTrab);
            this.Controls.Add(this.txtSalarioMin);
            this.Controls.Add(this.groupTurno);
            this.Name = "Form1";
            this.Text = "Calculo ";
            this.groupTurno.ResumeLayout(false);
            this.groupTurno.PerformLayout();
            this.groupCategoria.ResumeLayout(false);
            this.groupCategoria.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupTurno;
        private System.Windows.Forms.RadioButton rdoMatutino;
        private System.Windows.Forms.RadioButton rdoVespetino;
        private System.Windows.Forms.RadioButton rdoNoturno;
        private System.Windows.Forms.TextBox txtSalarioMin;
        private System.Windows.Forms.TextBox txtHorasTrab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupCategoria;
        private System.Windows.Forms.RadioButton rdoCalouro;
        private System.Windows.Forms.RadioButton rdoVeterano;
        private System.Windows.Forms.ListBox lbxResumo;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.Button button1;
    }
}

