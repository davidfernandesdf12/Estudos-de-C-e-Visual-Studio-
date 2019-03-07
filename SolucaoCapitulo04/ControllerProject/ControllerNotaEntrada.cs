using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using PersistenceProject;

namespace ControllerProject
{
    public class ControllerNotaEntrada
    {
        Repository repository = new Repository();
        Produto produtos = new Produto();

        public NotaEntrada InsertOrUpdate(NotaEntrada notaEntrada)
        {
            if(notaEntrada.Id.Equals(Guid.Empty))
                return this.repository.SaveOrUpdateNotaEntrada(notaEntrada);
            else
                return this.repository.SaveOrUpdateNotaEntrada(notaEntrada);
        }

        public void Remove(NotaEntrada notaEntrada)
        {
            this.repository.RemoverNotaEntrada(notaEntrada);
        } 

        public IList<NotaEntrada> GetAll()
        {
            return this.repository.GetAllNotaEntradas();
        }

        public NotaEntrada GetNotaEntradaById(Guid Id)
        {
            return this.repository.GetNotaEntradaById(Id);
        }

       

    }
}
