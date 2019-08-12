using System;
using System.Collections.Generic;

namespace CRM.Repository
{
    public interface IRepository<T> where T : class
    {
        T Get(Func<T, bool> predicate);
        IList<T> GetList(Func<T,bool> predicate);
        T Update(T t);
        T Save(T t);
        void Delete(T t);
    }
}
