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

namespace ADO_NETProject01
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
            GetAllFornecedores();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Obter connection string do app.config
            string connectionString = ConfigurationManager.ConnectionStrings["CS_ADO_NET"].ConnectionString;
            //Objeto responsável pela conexão com o banco de dados
            SqlConnection connection = new SqlConnection(connectionString);

            //Abrindo conexão com a base de dados
            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandText = "INSERT INTO FORNECEDORES(nome, cnpj) values (@nome, @cnpj)";
            command.Parameters.AddWithValue("@nome", txtNome.Text);
            command.Parameters.AddWithValue("@cnpj", txtCnpj.Text);
            command.ExecuteNonQuery();
            connection.Close();

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
        }
    }
}
