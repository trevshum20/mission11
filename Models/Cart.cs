using System;
using System.Collections.Generic;
using System.Linq;

namespace BookStore1.Models.ViewModels
{
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public void AddItem(Books book, int qty)
        {
            CartLineItem line = Items
                .Where(p => p.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Price = book.Price,
                    Quantity = qty

                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public double CalculateTotal()
        {
            double product = Items.Sum(x => x.Quantity * x.Price);
            return product;
        }
    }


    public class CartLineItem
    {
        public int LineID { get; set; }
        public Books Book { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
