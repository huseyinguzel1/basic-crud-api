using Business.Abstract;
using DataAccess.EntityFramework.Abstract;
using Entity.Concrete;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManager : IAuthorService
    {
        private IAuthorDal _authorDal;

        public AuthorManager(IAuthorDal authorDal) => _authorDal = authorDal;

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetAll().ToList();
        }

        public List<Author> GetById(int authorId)
        {
            return _authorDal.GetById(a => a.Id == authorId).ToList();
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
