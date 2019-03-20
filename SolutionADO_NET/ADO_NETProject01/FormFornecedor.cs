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
            command.CommandText = "insert into FORNECEDORES(nome, cnpj) values(@nome, @cnpj)";
            command.Parameters.AddWithValue("@nome", txtNome);
            command.Parameters.AddWithValue("@cnpj", txtCnpj);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Fornecedor registrado com sucesso");
        }
    }
}
