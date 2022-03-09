using System;
using System.Linq;

namespace BookStore1.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Books> Books { get; }

        public void SaveBook(Books b);

        public void CreateBook(Books b);

        public void DeleteBook(Books b);
    }
}
