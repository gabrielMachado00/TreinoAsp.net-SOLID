using ProjetoCrm.Infra.Data.Context;
using ProjetoCrm.Infra.Data.Interface;
using ProjetoCrm.Infra.Data.IServiceBase;
using ProjetoCrm.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCrm.Infra.Data.ServiceBase
{
    public class RepositorioService<TEntity> : IDisposable, IRepositorioService<TEntity> where TEntity : class

    {
        private readonly IRepositorioBase<TEntity> _db;

        public RepositorioService(IRepositorioBase<TEntity> db)
        {
            _db = db;

        }

        public void Add(TEntity obj)
        {
            _db.Add(obj);
 
            
                
                }
        public void Delete(TEntity obj)

        {
            _db.Remove(obj);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _db.GetAll();
        }

        public TEntity FindById(int id) {

            return _db.FindByid(id);
        }



        public void Update(TEntity obj)
        {
            _db.Update(obj);
        }

 

 
    }
}
