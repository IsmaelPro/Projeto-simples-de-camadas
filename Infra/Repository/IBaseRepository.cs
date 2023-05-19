using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : BaseClass
    {
        IQueryable<TEntity> Get();

        TEntity GetById(int id);

        TEntity Insert(TEntity entity);

        TEntity Update(TEntity entity);

        bool Delete(int id);

        bool Delete(TEntity entity);
    }
}