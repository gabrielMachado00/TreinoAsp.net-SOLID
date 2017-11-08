using System;
using System.Collections.Generic;
using ProjetoCrm.Domain.Entities;

namespace ProjetoCrm.Domain.Interface.Repository
{
    public interface IUsuarioRepository : IDisposable
    {
        Usuario ObterPorId(string id);
        IEnumerable<Usuario> ObterTodos();
        void DesativarLock(string id);
    }
}