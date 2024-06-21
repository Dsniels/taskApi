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
        public Expression<Func<T, bool>> Criteria => throw new NotImplementedException();

        public Expression<Func<T, object>> OrderBy => throw new NotImplementedException();

        public Expression<Func<T, object>> OrderByDescending => throw new NotImplementedException();

        public List<Expression<Func<T, object>>> Includes => throw new NotImplementedException();

        public int Take => throw new NotImplementedException();

        public int Skip => throw new NotImplementedException();

        public bool IsPagingEnable => throw new NotImplementedException();
    }
}
