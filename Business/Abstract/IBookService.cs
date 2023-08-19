using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{

    public interface IBookService
    {
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
        List<Book> GetAll();
        List<Book> GetByAuthorId(int authorId);
        List<Book> GetById(int bookId);
    }
}
