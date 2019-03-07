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
    public partial class FormNotaEntrada : Form
    {
        private ControllerNotaEntrada controller;
        private FornecedorController fornecedorController;
        private ControllerProduto produtoController;

        private NotaEntrada notaAtual;


        public FormNotaEntrada(ControllerNotaEntrada controller, FornecedorController fornecedorController, ControllerProduto produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;

            //inicializa o preenchimento dos comboboxs fornecedor e produtos
            InicializaComboBoxs();
        }

        #region Métodos NotaEntrada
        //function de preenchimento dos comboboxs fornecedor e produtos
        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();

            foreach (Fornecedor fornecedor in this.fornecedorController.GetAll())
            {
                cbxFornecedor.Items.Add(fornecedor);
                cbxFornecedor.ValueMember = "Id";
                cbxFornecedor.DisplayMember = "Nome";
            }

            foreach (Produto produto in this.produtoController.GetAll())
            {
                cbxProduto.Items.Add(produto);
                cbxProduto.ValueMember = "Id";
                cbxProduto.DisplayMember = "Descricao";
            }

        }

        //limpar controles da nota de entrada
        private void ClearControlsNota()
        {
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            txtIDNota.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cbxFornecedor.Focus();
        }

        private void btnNovoNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void btnGravarNota_Click(object sender, EventArgs e)
        {
            var notaEntrada = new NotaEntrada()
            {
                Id = (string.IsNullOrEmpty(txtIDNota.Text) ? Guid.Empty : new Guid(txtIDNota.Text)),
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                fornecedorNota = (Fornecedor)cbxFornecedor.SelectedItem,
                Numero = txtNumero.Text
            };
            notaEntrada = this.controller.InsertOrUpdate(notaEntrada);
            dgvNotasEntrada.DataSource = null;
            dgvNotasEntrada.DataSource = this.controller.GetAll();
            dgvNotasEntrada.Columns.RemoveAt(2);
            ClearControlsNota();
        }

        private void btnCancelarNota_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        private void btnRemoverNota_Click(object sender, EventArgs e)
        {
            if (txtIDNota.Text.Equals(string.Empty))
            {
                MessageBox.Show("Selecione a NOTA a ser removida na GRID");
            }
            else
            {
                this.controller.Remove(new NotaEntrada()
                {
                    Id = new Guid(txtIDNota.Text)
                });
                dgvNotasEntrada.DataSource = null;
                dgvNotasEntrada.DataSource = this.controller.GetAll();
                ClearControlsNota();
            }
        }

        private void UpdateProdutosGrid()
        {
            dgvProdutos.DataSource = null;
            if (this.notaAtual.Produtos.Count > 0)
            {
                dgvProdutos.DataSource = this.notaAtual.Produtos;
            }
        }

        private void dgvNotasEntrada_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.GetNotaEntradaById(new Guid(dgvNotasEntrada.CurrentRow.Cells[0].Value.ToString()));
                txtIDNota.Text = notaAtual.Id.ToString();
                txtNumero.Text = notaAtual.Numero.ToString();
                cbxFornecedor.SelectedItem = notaAtual.fornecedorNota;
                dtpEmissao.Value = notaAtual.DataEmissao;
                dtpEntrada.Value = notaAtual.DataEntrada;
                UpdateProdutosGrid();
            }
            catch (Exception ex)
            {
                this.notaAtual = new NotaEntrada();
            }
        }
        #endregion


        private void ClearControlsProduto()
        {
            dgvProdutos.ClearSelection();
            txtIDProduto.Text = string.Empty;
            cbxProduto.SelectedIndex = -1;
            txtCusto.Text = string.Empty;
            txtQuantidade.Text = string.Empty;

        }
        private void btnNovoProduto_Click(object sender, EventArgs e)
        {
            ClearControlsProduto();
            if (txtIDNota.Text == string.Empty)
                MessageBox.Show("Selecione a NOTA, que terá inserção de produtos, no GRID", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                ChangeStatusOfControls(true);

        }

        private void ChangeStatusOfControls(bool newStatus)
        {
            cbxProduto.Enabled = newStatus;
            txtCusto.Enabled = newStatus;
            txtQuantidade.Enabled = newStatus;
            btnNovoProduto.Enabled = !newStatus;
            btnGravarProduto.Enabled = newStatus;
            btnCancelarProduto.Enabled = newStatus;
            btnRemoverProduto.Enabled = newStatus;
        }


        private void btnGravarProduto_Click(object sender, EventArgs e)
        {
            var produtoNota = new NotaEntradaProduto()
            {
                Id = (string.IsNullOrEmpty(txtIDProduto.Text) ? Guid.Empty : new Guid(txtIDProduto.Text)),
                PrecoCustoCompra = Convert.ToDouble(txtCusto.Text),
                ProdutoNota = (Produto) cbxProduto.SelectedItem,
                QuantidadeCompra = Convert.ToDouble(txtQuantidade.Text)
            };

            this.notaAtual.RegistrarProduto(produtoNota);
            this.notaAtual = this.controller.InsertOrUpdate(this.notaAtual);
            ChangeStatusOfControls(false);
            update
            ClearControlsProduto();
        }
    }
}
