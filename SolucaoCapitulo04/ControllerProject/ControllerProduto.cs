using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using PersistenceProject;

namespace ControllerProject
{
    public class ControllerProduto
    {
        private Repository repository = new Repository();

        public Produto Insert(Produto produto)
        {
            return this.repository.SaveOrUpdateProduto(produto);
        }

        public void Remover(Produto produto)
        {
            this.repository.RemoveProduto(produto);
        }

        public IList<Produto> GetAll()
        {
            return this.repository.GetAllProdutos();
        }

        public Produto Update(Produto produto)
        {
            return this.repository.SaveOrUpdateProduto(produto);
        }
    }
}
