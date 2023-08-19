using Core.DataAccess.EntiyFramwork;
using DataAccess.EntityFramework.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework.Concrete
{
    public class EfAuthorDal : EfEntityRepository<Author, BookContext>, IAuthorDal
    {
    }
}
