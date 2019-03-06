using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormJanelaPrincipal : Form
    {
        public FormJanelaPrincipal()
        {
            InitializeComponent();
        }

        private FornecedorController fornecedorController = new FornecedorController();
        private ControllerProduto produtoController = new ControllerProduto();
        private ControllerNotaEntrada notaEntradaController = new ControllerNotaEntrada();

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).ShowDialog();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto(produtoController).ShowDialog();
        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotaEntrada(notaEntradaController, fornecedorController, produtoController).ShowDialog();
        }
    }
}
