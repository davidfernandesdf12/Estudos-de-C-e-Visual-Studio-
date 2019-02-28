using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class NotaEntradaProduto
    {
        public Guid Id { get; set; }
        public Produto ProdutoNota { get; set; }
        public double PrecoCustoCompra { get; set; }
        public double QuantidadeCompra { get; set; }

        #region Métodos Equals e GetHasCode

        protected bool Equals(NotaEntradaProduto other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(Object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != typeof(NotaEntradaProduto))
                return false;

            return Equals((NotaEntradaProduto)obj);
        }

        public override int GetHashCode()
        {
            return ProdutoNota.GetHashCode();
        }
        #endregion
    }
}
