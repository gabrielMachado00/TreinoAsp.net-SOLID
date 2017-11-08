﻿using ProjetoCrm.Domain.Entities;
using ProjetoCrm.Infra.Data.Interface;
using ProjetoCrm.Infra.Data.IServiceBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.ServiceBase
{
   public class ClienteService:RepositorioService<Cliente>,IClienteService
    {

        private readonly IClienteRepositorio _repositorio;

        public ClienteService(IClienteRepositorio repositorio):base(repositorio)
        {
            _repositorio = repositorio;

        }
    }
}