using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelProject;

using ControllerProject;

namespace ViewProject
{
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();

        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            var fornecedor = this.controller.InsertOrUpdate(
                new Fornecedor() {
                    Id = null,
                    Nome = txtNome.Text,
                    CNPJ = txtCnpj.Text
                });
            txtId.Text = fornecedor.Id.ToString();
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnpj.Text = string.Empty;
        }

        private void ClearControls()
        {
            txtId.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
