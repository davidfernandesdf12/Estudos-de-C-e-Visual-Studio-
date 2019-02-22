using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PesoIdeal
{
    public partial class CalcPesoideal : Form
    {
        public CalcPesoideal()
        {
            InitializeComponent();
            rbnMasculino.Checked = true;
        }

        private void CalcPesoideal_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rbnSelecionado.ToString()))
            {
                MessageBox.Show("Por favor, informe o sexo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if ((string.IsNullOrEmpty(txtAltura.Text)))
            {
                MessageBox.Show("Por favor, informe a altura", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            var sexo = Convert.ToInt32(rbnSelecionado.Tag);

            double altura = Convert.ToDouble(txtAltura.Text);
            double calPesoIdeal;
            if (sexo == 0)
                calPesoIdeal = (altura * 72.7) - 58;
            
            else
                calPesoIdeal = (altura * 62.1) - 44.7;


            lblvaluepesoideal.Text = calPesoIdeal.ToString("N");


        }

        private void rbnMasculino_CheckedChanged(object sender, EventArgs e)
        {
            if(rbnMasculino.Checked == true)
            {
                rbnSelecionado.Tag = 0;
            }
            else
            {
                rbnSelecionado.Tag = 1;
            }
        }

        private void rbnFeminino_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnFeminino.Checked == true)
            {
                rbnSelecionado.Tag = 1;
            }
            else
            {
                rbnSelecionado.Tag = 0;
            }
        }
    }
}
