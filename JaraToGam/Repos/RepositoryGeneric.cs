using JaraToGam.Interface;
using JaraToGam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace JaraToGam.Repos
{
    public class RepositoryGeneric<T> : IGeneric<T>, IDisposable where T : class
    {
        protected GamContext GamContext { get; set; }

        public RepositoryGeneric(GamContext gamContext)
        {
            this.GamContext = gamContext;
        }

        public void Add(T Entitie)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();  
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.GamContext.Set<T>().Where(expression);
        }

        public List<T> List()
        {
            throw new NotImplementedException();
        }

        public void Update(T Entitie)
        {
            throw new NotImplementedException();
        }
    }
}
