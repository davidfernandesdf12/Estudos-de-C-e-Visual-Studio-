using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControllerProject;
using ModelProject;

namespace ViewProject
{
    public partial class FormProduto : Form
    {
        private ControllerProduto controller = new ControllerProduto();

        public FormProduto(ControllerProduto controller)
        {
            InitializeComponent();
            this.controller = controller;
            if (controller.GetAll().Count > 0)
            {
                GetAllProdutos();
            }
        }

        private void ClearControls()
        {
            dgvProdutos.ClearSelection();
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtDescricao.Focus();
        }

        private void GetAllProdutos()
        {
                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = this.controller.GetAll();
                ClearControls();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtPrecoCusto.Text = string.Empty;
            txtPrecoVenda.Text = string.Empty;
            txtEstoque.Text = string.Empty;
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            var produto = this.controller.InsertOrUpdate(
                new Produto() {
                    Id = (string.IsNullOrEmpty(txtId.Text) ? Guid.Empty : new Guid(txtId.Text)),
                    Descricao = txtDescricao.Text,
                    PrecoDeCusto = (Convert.ToDouble(txtPrecoCusto.Text)),
                    ProcoDevenda = (Convert.ToDouble(txtPrecoVenda.Text)),
                    Estoque = (Convert.ToDouble(txtEstoque.Text))
                });
            txtId.Text = produto.Id.ToString();
            GetAllProdutos();
        }

        private void dgvProdutos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvProdutos.SelectedRows.Count > 0)
            {
                txtId.Text = dgvProdutos.CurrentRow.Cells[0].Value.ToString();
                txtDescricao.Text = dgvProdutos.CurrentRow.Cells[1].Value.ToString();
                txtPrecoCusto.Text = dgvProdutos.CurrentRow.Cells[2].Value.ToString();
                txtPrecoVenda.Text = dgvProdutos.CurrentRow.Cells[3].Value.ToString();
                txtEstoque.Text = dgvProdutos.CurrentRow.Cells[4].Value.ToString();

            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txtId.Text.Equals(string.Empty))
            {
                MessageBox.Show("Selecione o PRODUTO a ser removido no GRID", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.controller.Remover(new Produto()
                {
                    Id = new Guid(txtId.Text)
                });
                GetAllProdutos();
            }
        }

        private void btnCancalar_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
