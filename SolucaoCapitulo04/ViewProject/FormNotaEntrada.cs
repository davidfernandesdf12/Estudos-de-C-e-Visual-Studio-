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

        //function de preenchimento dos comboboxs fornecedor e produtos
        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();

            foreach(Fornecedor fornecedor in this.fornecedorController.GetAll())
            {
                cbxFornecedor.Items.Add(fornecedor);
                cbxFornecedor.ValueMember = "Id";
                cbxFornecedor.DisplayMember = "Nome";
            }

            foreach(Produto produto in this.produtoController.GetAll())
            {
                cbxProduto.Items.Add(produto);
                cbxFornecedor.ValueMember = "Id";
                cbxFornecedor.DisplayMember = "Nome";
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
    }
}
