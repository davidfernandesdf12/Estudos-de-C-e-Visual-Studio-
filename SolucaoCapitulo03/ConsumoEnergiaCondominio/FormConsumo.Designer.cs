namespace ConsumoEnergiaCondominio
{
    partial class FormConsumo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtNrCasa = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.BtnProcessar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nr. Casa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumo:";
            // 
            // txtNrCasa
            // 
            this.txtNrCasa.Location = new System.Drawing.Point(76, 6);
            this.txtNrCasa.Name = "txtNrCasa";
            this.txtNrCasa.Size = new System.Drawing.Size(64, 22);
            this.txtNrCasa.TabIndex = 2;
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(223, 7);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(90, 22);
            this.txtConsumo.TabIndex = 3;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(323, 5);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(93, 26);
            this.BtnRegistrar.TabIndex = 4;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(15, 35);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.RowTemplate.Height = 24;
            this.dgvLeituras.Size = new System.Drawing.Size(401, 150);
            this.dgvLeituras.TabIndex = 5;
            // 
            // BtnProcessar
            // 
            this.BtnProcessar.Location = new System.Drawing.Point(15, 193);
            this.BtnProcessar.Name = "BtnProcessar";
            this.BtnProcessar.Size = new System.Drawing.Size(125, 32);
            this.BtnProcessar.TabIndex = 6;
            this.BtnProcessar.Text = "Processar dados";
            this.BtnProcessar.UseVisualStyleBackColor = true;
            this.BtnProcessar.Click += new System.EventHandler(this.BtnProcessar_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(142, 202);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(217, 17);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Total de consumo sem desconto:";
            // 
            // FormConsumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 237);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.BtnProcessar);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtNrCasa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConsumo";
            this.Text = "Consumo de energia de uma condomínio";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNrCasa;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.Button BtnProcessar;
        private System.Windows.Forms.Label lblResultado;
    }
}

