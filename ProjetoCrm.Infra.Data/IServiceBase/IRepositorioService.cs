using ProjetoCrm.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.IServiceBase
{
   public interface IRepositorioService<TEntity> where TEntity:class
    {

        void Add(TEntity obj);
        void Update(TEntity obj);
        void Delete(TEntity obj);
        IEnumerable<TEntity> GetAll();
        TEntity FindById(int id);
        void Dispose();
      

        }

    }

