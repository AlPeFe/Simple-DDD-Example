using JaraToGam.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace JaraToGam.Interface
{
    public interface IGeneric<T> where
        T : class
    {
        void Add(T Entitie);

        void Update(T Entitie);

        void Delete(int id);

        List<T> List();

        IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
