using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEserDal : IEserDal
    {
        public void Add(Eser entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Eser entity)
        {
            throw new NotImplementedException();
        }

        public Eser Get(Expression<Func<Eser, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Eser> GetAll(Expression<Func<Eser, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Eser entity)
        {
            throw new NotImplementedException();
        }
    }
}
