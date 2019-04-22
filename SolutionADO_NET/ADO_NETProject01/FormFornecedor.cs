using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using Model;
using DAL;

namespace ADO_NETProject01
{
    public partial class FormFornecedor : Form
    {
        private Fornecedor fornecedorAtual;
        private DAL_Fonecedor dal = new DAL_Fonecedor();

        public FormFornecedor()
        {
            InitializeComponent();
            GetAllFornecedores();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor(){
                Id = !string.IsNullOrEmpty(txtID.Text) ? long.Parse(txtID.Text) : (long?)null,
                Nome = txtNome.Text,
                Cnpj = txtCnpj.Text
            };

            this.dal.SaveOrUpdate(fornecedor);

            //MessageBox.Show("Fornecedor registrado com sucesso");
            ClearControls();
            GetAllFornecedores();
        }

        private void GetAllFornecedores()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            var adapter = new SqlDataAdapter("SELECT id, cnpj, nome FROM FORNECEDORES", connectionString);
            var builder = new SqlCommandBuilder(adapter);

            var table = new DataTable();
            adapter.Fill(table);

            dgvFornecedores.DataSource = table;

            connection.Close();

        }

        private void ClearControls()
        {
            txtID.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            txtNome.Text = string.Empty;
            GetAllFornecedores();
            dgvFornecedores.ClearSelection();
            this.fornecedorAtual = null;
            txtNome.Focus();
        }

        private Fornecedor GetFornecedorById(long id)
        {
            Fornecedor fornecedor = new Fornecedor();
            var connection = DBConnection.DB_Connection;
            var command = new SqlCommand("SELECT id, cnpj, nome FROM FORNECEDORES WHERE id = @id");
            command.Parameters.AddWithValue("@id",id);
            command.Connection = connection;
            connection.Open();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    fornecedor.Id = reader.GetInt32(0);
                    fornecedor.Cnpj = reader.GetString(1);
                    fornecedor.Nome = reader.GetString(2);
                }
            }
            connection.Close();
            return fornecedor;
        }

        private void dgvFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvFornecedores.Rows.Count > 0)
            {
                this.fornecedorAtual = GetFornecedorById(Convert.ToInt64(dgvFornecedores.Rows[e.RowIndex].Cells[0].Value));
                txtID.Text = this.fornecedorAtual.Id.ToString();
                txtNome.Text = this.fornecedorAtual.Nome;
                txtCnpj.Text = this.fornecedorAtual.Cnpj;
            }
            else
            {
                MessageBox.Show("Fornecedor Inexistente");
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(txtID.Text == string.Empty)
            {
                MessageBox.Show("Selecione o FORNECEDOR a ser removido no GRID");
            }
            else
            {
                this.dal.RemoveById(this.fornecedorAtual.Id);
                ClearControls();
                MessageBox.Show("Fornecedor removido com sucesso");
            }
        }
    }
}
