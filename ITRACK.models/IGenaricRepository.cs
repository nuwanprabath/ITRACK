using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
   public interface IGenaricRepository<TEntity>
    {


        Task<TEntity> GetIdByAsync(int Id);

        Task<TEntity> GetkeyByAsync(string Id);

        IQueryable<TEntity> SearchFor(Expression<Func<TEntity,bool>> predicate  );

        IQueryable<TEntity> GetAll();

        Task<List<TEntity>> GetAllData();

        Task EditAsync(TEntity entity);

        Task AddAsync(TEntity entity);

        bool Add(TEntity entity);


        bool Edit(TEntity entity);

        Task DeleteAsync(TEntity entity);

    }
}
