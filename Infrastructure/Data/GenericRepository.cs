using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entites;
using Core.Interfaces;

namespace Infrastructure.Data
{
    //baseEntityler de yapacağımız işlemlerin implemetasyonu burada yapılacak yani repository classlarımız.
    public class GenericRepository<T> : IGenericRepository<T> where T:BaseEntity
    {
        public Task<T> GetByIdAsycn(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<T>> ListAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}