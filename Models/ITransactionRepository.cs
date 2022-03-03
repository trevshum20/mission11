using System;
using System.Linq;

namespace BookStore1.Models
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transactions { get; }

        void SaveTransaction(Transaction transaction);
    }
}
