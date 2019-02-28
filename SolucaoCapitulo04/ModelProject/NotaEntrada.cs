using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class NotaEntrada
    {
        public Guid Id { get; set; }
        public string Numero { get; set; }
        public Fornecedor fornecedor { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<NotaEntradaProduto> Produtos { get; set; }

        #region Métodos NotaEntrada
        
        //Trazer todos meus produtos na nota de entrada
        public NotaEntrada()
        {
            this.Produtos = new List<NotaEntradaProduto>();
        }
        // Inserir produto na nota de entrada
        public void RegistrarProduto(NotaEntradaProduto produto)
        {
            if (!this.Produtos.Contains(produto))
            {
                this.Produtos.Add(produto);
            }
        }
        // Remover produto da nota de entrada 
        public void RemoverProduto(NotaEntradaProduto produto)
        {
            this.Produtos.Remove(produto);
        }
        public void RemoverTodosProdutos()
        {
            this.Produtos.Clear();
        }
        #endregion
    }

}
