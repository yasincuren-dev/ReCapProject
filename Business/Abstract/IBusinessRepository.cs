using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBusinessRepository<T>
    {
        List<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
