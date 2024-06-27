using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecifications<T> : ISpecifications<T> where T : ClaseBase
    {
        public BaseSpecifications(){}

        public BaseSpecifications(Expression<Func<T,bool>> criteria)
        {
            Criteria = criteria;
        }
        
        public Expression<Func<T, bool>> Criteria { get; }


        public Expression<Func<T, object>> OrderBy { get; private set; }
        public void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OrderBy = orderByExpression;
        }
        public Expression<Func<T, object>> OrderByDescending {get; private set; }
        public void AddOrderByDescending(Expression<Func<T,object>> orderByDescExpression)
        {
            OrderByDescending = orderByDescExpression;
        }
        public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T,object>>>();
        public void AddInclude(Expression<Func<T, object>> includeExpression) { Includes.Add(includeExpression); }

        public int Take { get; private set; }

        public int Skip { get; private set; }


        public bool IsPagingEnable { get; private set; }

        public void ApplyPaginng(int skip, int take)
        {
            Skip = skip;
            Take = take;
            IsPagingEnable = true;
        }

    }
}
