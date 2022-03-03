using System;
using System.Text.Json.Serialization;
using Bookstore1.Models.Infrastructure;
using BookStore1.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore1.Models
{
    public class SessionCart : Cart
    {
        public static Cart GetCart (IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session?.GetJson<SessionCart>("Cart") ?? new SessionCart();
            cart.Session = session;
            return cart;

        }

        [JsonIgnore]
        public ISession Session { get; set; }

        public override void AddItem(Books book, int qty) // why do we have to override?
        {
            base.AddItem(book, qty);
            Session.setJson("Cart", this);
        }

        public override void RemoveItem(Books book)
        {
            base.RemoveItem(book);
            Session.setJson("Cart", this);
        }

        public override void ClearCart()
        {
            base.ClearCart();
            Session.Remove("Cart");
        }
    }
}
