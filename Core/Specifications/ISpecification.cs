using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Criteria{get;}
        List<Expression<Func<T,Object>>> Includes{get;}
        Expression<Func<T,Object>> OrderBy {get;}
        Expression<Func<T,Object>> OrderByDescending {get;}

        int Take {get;}
        int Skip {get ;}
        bool IsPagingEnabled {get;}
        

    }
}