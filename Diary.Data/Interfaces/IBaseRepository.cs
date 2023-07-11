using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity? FindById(uint id);

        IList<TEntity> GetAll();

        void Insert(TEntity entity);

        void Update(TEntity entity);

        void Delete(uint id);

    }
}
