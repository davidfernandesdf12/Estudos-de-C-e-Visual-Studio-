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

        public NotaEntrada Insert(NotaEntrada notaEntrada)
        {
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

        public NotaEntrada Update(NotaEntrada notaEntrada)
        {
            return this.repository.SaveOrUpdateNotaEntrada(notaEntrada);
        }
    }
}
