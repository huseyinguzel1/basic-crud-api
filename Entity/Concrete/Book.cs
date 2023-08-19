using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Book : IEntity
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
    }
}
