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
                    Id = (txtId.Text == string.Empty ? Guid.Empty : new Guid(txtId.Text)),
                    Nome = txtNome.Text,
                    CNPJ = txtCnpj.Text
                });
            txtId.Text = fornecedor.Id.ToString();
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnpj.Text = string.Empty;
        }

        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            txtNome.Focus();
        }

        private void dgvFornecedores_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvFornecedores.Rows.Count < 0)
            { 
            txtId.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals(string.Empty))
            {
                MessageBox.Show("Selecione o FORNECEDOR a ser removido no GRID", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                this.controller.Remover(
                    new Fornecedor
                    {
                        Id = new Guid(txtId.Text),
                        Nome = txtNome.Text,
                        CNPJ = txtCnpj.Text
                    });
                    dgvFornecedores.DataSource = null;
                    dgvFornecedores.DataSource = this.controller.GetAll();
                    ClearControls();
            }
            
        }
    }
}
