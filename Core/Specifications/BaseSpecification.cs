using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<T> : ISpecification<T>
    {
        public BaseSpecification()
        {
           
        }
        public BaseSpecification(Expression<Func<T, bool>> criteria)
        {
            Criteria = criteria;
           
        }

        public Expression<Func<T, bool>> Criteria {get;}

        public List<Expression<Func<T, Object>>> Includes  {get;} =
         new List<Expression<Func<T,Object>>>();

        public Expression<Func<T, Object>> OrderBy {get ; private set;}

        public Expression<Func<T, Object>> OrderByDescending {get ; private set;}

        public int Take {get ; private set;}

        public int Skip {get ; private set;}

        public bool IsPagingEnabled{get ; private set;} 

        protected void AddInclude(Expression<Func<T,object>> includeExpression)
        {
            Includes.Add(includeExpression);
        }
        protected void AddOrderBy(Expression<Func<T,Object>> orderByExpression)
        {
            OrderBy =orderByExpression;
        }
        protected void AddOrderByDescending(Expression<Func<T,Object>> orderByDescExpression)
        {
            OrderBy =orderByDescExpression;
        }
        protected void ApplyPaging(int skip,int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnabled = true;
        }

    }
}