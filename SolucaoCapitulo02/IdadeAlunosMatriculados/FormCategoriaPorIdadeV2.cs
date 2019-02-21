using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IdadeAlunosMatriculados
{
    public partial class FormCategoriaPorIdadeV2 : Form
    {
        public FormCategoriaPorIdadeV2()
        {
            InitializeComponent();
            lblHoje.Text += " " + DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void lblHoje_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(dtpDataDeNascimento.ToString()))
            {
                MessageBox.Show("Por favor insirá todos os dados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var date = DateTime.Now.Subtract(dtpDataDeNascimento.Value);
                var idade = date.Days / 365;
                if (idade > 17)
                    lblCategoria.Text = "Adulto";
                else if (idade > 13)
                    lblCategoria.Text = "Juvenil B";
                else if (idade > 10)
                    lblCategoria.Text = "Juvenil A";
                else if (idade > 7)
                    lblCategoria.Text = "Infantil B";
                else if (idade >= 5)
                    lblCategoria.Text = "Infantil A";
                else
                {
                    lblCategoria.Text = "Não existe categoria";
                }
            }
        }
    }
}
