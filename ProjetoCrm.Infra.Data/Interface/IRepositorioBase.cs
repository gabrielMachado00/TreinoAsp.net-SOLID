using ProjetoCrm.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.Interface
{
    public interface IRepositorioBase<TEntity> where TEntity:class
    {

        void Add(TEntity obj);
        TEntity FindByid(int id);
        void Update(TEntity obj);
        IEnumerable<TEntity> GetAll();
        void Remove(TEntity obj);
        void Dispose();
  


    }
}
