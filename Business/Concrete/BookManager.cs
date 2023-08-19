using Business.Abstract;
using DataAccess.EntityFramework.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal) => _bookDal = bookDal;
        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetByAuthorId(int authorId)
        {
            return _bookDal.GetById(b => b.AuthorId == authorId).ToList();
        }

        public List<Book> GetById(int bookId)
        {
            return _bookDal.GetById(b => b.BookId == bookId).ToList();
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
