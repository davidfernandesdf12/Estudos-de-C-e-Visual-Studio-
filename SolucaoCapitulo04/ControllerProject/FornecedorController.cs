using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using PersistenceProject;

namespace ControllerProject
{
    public class FornecedorController
    {
        private Repository repository = new Repository();

        public Fornecedor InsertOrUpdate(Fornecedor fornecedor)
        {
            return this.repository.SaveOrUpdateFornecedor(fornecedor);
        }

        public void Remover(Fornecedor fornecedor)
        {
            this.repository.RemoveFornecedor(fornecedor);
        }

        public IList<Fornecedor> GetAll()
        {
            return this.repository.GetAllFornecedores();
        }
        
    }
}
