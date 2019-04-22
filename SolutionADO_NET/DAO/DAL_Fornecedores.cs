using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class DAL_Fornecedores
    {
        private SqlConnection connection = DBConnection.DB_Connection;

        public void RemoverById(long id)
        {
            var command = new SqlCommand("DELETE FROM FORNECEDORES WHERE Id = @id", connection);
            command.Parameters.AddWithValue("@id", id);
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
