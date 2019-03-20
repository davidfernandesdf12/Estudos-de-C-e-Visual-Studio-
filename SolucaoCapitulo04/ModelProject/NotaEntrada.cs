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
        public Fornecedor fornecedorNota { get ; set; }
        public string nomeFornecedor { get { return string.IsNullOrEmpty(fornecedorNota.Nome) ? "" : fornecedorNota.Nome; } }
        public DateTime DataEmissao { get; set; }
        public DateTime DataEntrada { get; set; }
        public IList<NotaEntradaProduto> Produtos { get; set; }

        public IList<NotaEntradaProduto> ProdutosNota = new List<NotaEntradaProduto>();

        #region Métodos Equals e GetHashCode

        protected bool Equals(NotaEntrada other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(true, obj))
                return true;
            if (obj.GetType() != typeof(NotaEntrada))
                return false;

            return Equals((NotaEntrada)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

        #region Métodos - NotaEntradaProduto
        public void RegistrarProduto(NotaEntradaProduto produto)
        {
            if(ProdutosNota.Count > 0)
            {
                ProdutosNota = Produtos;

                if (this.ProdutosNota.Contains(produto))
                {
                    this.Produtos.Remove(produto);
                }
                else
                {
                    produto.Id = Guid.NewGuid();
                    this.Produtos.Add(produto);
                }

            }
            else
            {
                produto.Id = Guid.NewGuid();
                Produtos = ProdutosNota;
                this.Produtos.Add(produto);
            }


        }

        public void RemoverProduto(NotaEntradaProduto produto)
        {
            this.Produtos.Remove(produto);
        }
        #endregion

    }

}
