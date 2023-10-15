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
    public class EfSanatciDal : ISanatciDal
    {
        public void Add(Sanatci entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Sanatci entity)
        {
            throw new NotImplementedException();
        }

        public Sanatci Get(Expression<Func<Sanatci, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Sanatci> GetAll(Expression<Func<Sanatci, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Sanatci entity)
        {
            throw new NotImplementedException();
        }
    }
}
