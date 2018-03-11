using System;
using System.Collections.Generic;
using System.Data.Entity;
using DKPDAL.EF;
using DKPDAL.Repository.Interface;

namespace DKPDAL.Repository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : DkpEntityModel
    {
        private readonly DkpContext _db;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _db = DkpContext.Create();
            _dbSet = _db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
                _dbSet.Remove(entity);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed;

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
