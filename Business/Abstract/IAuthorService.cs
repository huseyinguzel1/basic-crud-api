using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthorService
    {
        void Add(Author author);
        void Delete(Author author);
        List<Author> GetAll();
        List<Author> GetById(int authorId);
        void Update(Author author);

    }
}
