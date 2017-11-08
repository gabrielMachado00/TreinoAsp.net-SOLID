using ProjetoCrm.Domain.Entities;
using ProjetoCrm.Infra.Data.Interface;
using ProjetoCrm.Infra.Data.IServiceBase;
using ProjetoCrm.Infra.Data.Repository;
using ProjetoCrm.Infra.Data.ServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.ServiceBase
{
    public class ProdutoService:RepositorioService<Produto>,IProdutoService   
    {
        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoService(IProdutoRepositorio produtoRepositorio):base(produtoRepositorio)
        {

            _produtoRepositorio=produtoRepositorio;

        }
    }
}
