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

namespace ADO_NETProject01
{
    public partial class FormFornecedor : Form
    {
        private Fornecedor fornecedorAtual;

        public FormFornecedor()
        {
            InitializeComponent();
            GetAllFornecedores();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            using (var connection = DBConnection.DB_Connection)
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "INSERT INTO FORNECEDORES(nome, cnpj) values (@nome, @cnpj)";
                command.Parameters.AddWithValue("@nome", txtNome.Text);
                command.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
                command.ExecuteNonQuery();
            }
            MessageBox.Show("Fornecedor registrado com sucesso");
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

            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = table;

            connection.Close();

        }

        private void ClearControls()
        {
            txtID.Text = string.Empty;
            txtCnpj.Text = string.Empty;
            txtNome.Text = string.Empty;
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
            if(e.RowIndex != 1)
            {
                MessageBox.Show("Fornecedor Inexistente");
            }
            else
            {
                this.fornecedorAtual = GetFornecedorById(Convert.ToInt64(dgvFornecedores.Rows[e.RowIndex].Cells[0].Value));
                txtID.Text = this.fornecedorAtual.Id.ToString();
                txtNome.Text = this.fornecedorAtual.Nome;
                txtCnpj.Text = this.fornecedorAtual.Cnpj;
            }



        }
    }
}
