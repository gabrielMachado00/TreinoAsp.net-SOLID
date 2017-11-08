using ProjetoCrm.Domain.Entities;
using ProjetoCrm.Infra.Data.Interface;
using ProjetoCrm.Infra.Data.IServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.ServiceBase
{
    public class EstoqueService:RepositorioService<Estoque>,IEstoqueService
    {
        private readonly IEstoqueRepositorio _estoqueRepositorio;
        public EstoqueService(IEstoqueRepositorio estoqueRepositorio):base(estoqueRepositorio)
        {
            _estoqueRepositorio = estoqueRepositorio;
        }
    }
}
