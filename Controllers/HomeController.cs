using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BookStore1.Models;
using BookStore1.Models.ViewModels;

namespace BookStore1.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository repo;

        public HomeController (IBookStoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string category, int pageNum = 1) // connects with the view models, gives information to the index view.
        {
            int pageSize = 5;

            var x = new BooksViewModel
            {
                Books = repo.Books
                    .Where(x => x.Category == category || category == null)
                    .OrderBy(k => k.Title)
                    .Skip((pageNum - 1) * pageSize)
                    .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks =
                        (category == null
                            ? repo.Books.Count()
                            : repo.Books.Where(x => x.Category == category).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
