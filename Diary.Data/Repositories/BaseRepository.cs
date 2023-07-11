using Diary.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {

        protected readonly NoteDbContext noteDbContext;
        protected readonly DbSet<TEntity> dbSet;

        public BaseRepository(NoteDbContext noteDbContext)
        {
            this.noteDbContext = noteDbContext;
            dbSet = noteDbContext.Set<TEntity>();
        }

        public void Delete(uint id)
        {
            TEntity entity = dbSet.Find(id);
            try
            {
                dbSet.Remove(entity);
                noteDbContext.SaveChanges();
            }
            catch (Exception)
            {
                noteDbContext.Entry(entity).State = EntityState.Unchanged;
                throw;
            }
        }

        public TEntity? FindById(uint id)
        {
            return dbSet.Find(id);
        }

        public IList<TEntity> GetAll()
        {
            return dbSet.ToList();
        }

        public void Insert(TEntity entity)
        {
            dbSet.Add(entity);
            noteDbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            if (dbSet.Contains(entity))
                dbSet.Update(entity);

            else
                dbSet.Add(entity);

            noteDbContext.SaveChanges();

        }
    }
}
