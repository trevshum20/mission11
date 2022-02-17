using System;
using System.Linq;

namespace BookStore1.Models
{
    public interface IBookStoreRepository
    {
        IQueryable<Books> Books { get; }
    }
}
