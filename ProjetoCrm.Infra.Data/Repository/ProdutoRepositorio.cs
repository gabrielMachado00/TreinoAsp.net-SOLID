using ProjetoCrm.Domain.Entities;
using ProjetoCrm.Infra.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.Repository
{
   public  class ProdutoRepositorio:RepositorioBase<Produto>,IProdutoRepositorio
    {
    }
}
