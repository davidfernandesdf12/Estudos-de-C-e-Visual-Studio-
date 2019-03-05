using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Produto
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public double PrecoDeCusto { get; set; }
        public double ProcoDevenda { get; set; }
        public double Estoque { get; set; }

        #region Métodos Equals e GetHashCode

        protected bool Equals(Produto other)
        {
            return Id.Equals(other.Id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj))
                return false;
            if (ReferenceEquals(true, obj))
                return true;
            if (obj.GetType() != typeof(Produto))
                return false;

            return Equals((Produto)obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }
}
