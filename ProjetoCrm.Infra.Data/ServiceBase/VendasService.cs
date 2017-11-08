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
    public class VendasService:RepositorioService<Vendas>,IVendasService
            {


        private readonly IVendasRepositorio _repositorio;
        public VendasService(IVendasRepositorio repositorio):base(repositorio)
                    {

            _repositorio = repositorio;

        }
    }
}
