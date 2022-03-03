using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore1.Models;
using BookStore1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore1.Controllers
{
    public class TransactionController : Controller
    {
        private ITransactionRepository repo { get; set; }
        private Cart cart { get; set; }

        public TransactionController (ITransactionRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Transaction());
        }

        [HttpPost]
        public IActionResult Checkout (Transaction transaction)
        {
            if (cart.Items.Count() == 0)
            {
                ModelState.AddModelError("", "Sorry, your cart is empty!");
            }

            if (ModelState.IsValid)
            {
                transaction.Lines = cart.Items.ToArray();
                repo.SaveTransaction(transaction);
                cart.ClearCart();
                return RedirectToPage("/TransactionCompleted");
            }
            else
            {
                return View();
            }
        }
    }
}
