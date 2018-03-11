using System;
using System.Collections.Generic;

namespace DKPDAL.Repository.Interface
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
