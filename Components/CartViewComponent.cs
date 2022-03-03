using System;
using BookStore1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BookStore1.Components
{
    public class CartViewComponent : ViewComponent
    {
        private Cart cart;

        public CartViewComponent(Cart c)
        {
            cart = c;
        }

        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}


//using Microsoft.AspNetCore.Mvc;
//using SportsStore.Models;
//namespace SportsStore.Components
//{
//    public class CartSummaryViewComponent : ViewComponent
//    {
//        private Cart cart;
//        public CartSummaryViewComponent(Cart cartService)
//        {
//            cart = cartService;
//        }
//        public IViewComponentResult Invoke()
//        {
//            return View(cart);
//        }
//    }
//}