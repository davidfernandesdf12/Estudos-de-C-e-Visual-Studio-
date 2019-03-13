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


    }

}
