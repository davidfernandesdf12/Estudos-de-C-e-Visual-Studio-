using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class DAL_Fonecedor
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoveById(long? id)
        {
            var commad = new SqlCommand("DELETE FROM FORNECEDORES WHERE Id = @id", connection);
            commad.Parameters.AddWithValue("@id", id);
            connection.Open();
            commad.ExecuteNonQuery();
            connection.Close();
        }

        private void Update(Fornecedor fornecedor)
        {
            var command = new SqlCommand("UPDATE FORNECEDORES SET cnpj=@cnpj, nome=@nome WHERE id=@id", this.connection);
            command.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            command.Parameters.AddWithValue("@id", fornecedor.Id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void Insert(Fornecedor fornecedor)
        {
            var command = new SqlCommand("INSERT INTO FORNECEDORES(nome, cnpj) values (@nome, @cnpj)", this.connection);
            command.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
            command.Parameters.AddWithValue("@nome", fornecedor.Nome);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

        public void SaveOrUpdate(Fornecedor fornecedor)
        {
            if (fornecedor.Id != null)
                this.Update(fornecedor);
            else
                this.Insert(fornecedor);

        }
    }
}
