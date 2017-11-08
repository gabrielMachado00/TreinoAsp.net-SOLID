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
    public class FuncionarioService:RepositorioService<Funcionario>,IFuncionarioService
    {
        private readonly IFuncionarioRepositorio _funcionarioRepositorio;
        public FuncionarioService(IFuncionarioRepositorio funcionarioRepositorio):base(funcionarioRepositorio)
                    {

            _funcionarioRepositorio = funcionarioRepositorio;

        }
    }
}
