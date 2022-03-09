using System;
using System.Linq;

namespace BookStore1.Models
{
    public class EFBookStoreRepository: IBookStoreRepository
    {
        private BookstoreContext context { get; set; }

        public EFBookStoreRepository (BookstoreContext yare)
        {
            context = yare;
        }

        public IQueryable<Books> Books => context.Books;

        public void SaveBook(Books b)
        {
            context.SaveChanges();
        }

        public void CreateBook(Books b)
        {
            context.Add(b);
            context.SaveChanges();
        }

        public void DeleteBook(Books b)
        {
            context.Remove(b);
            context.SaveChanges();
        }
    }
}
