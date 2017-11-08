using ProjetoCrm.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.Interface
{
   public interface IProdutoRepositorio:IRepositorioBase<Produto>,IDisposable
    {

    }
}
