using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using LibraryCW.Models;
using System;
using LibraryCW.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using LibraryCW.Areas.Identity.Data;

namespace LibraryCW.Controllers
{
    public class BookingBookController : Controller
    {
        private readonly AppDBContext _context;
        private readonly UserManager<LibraryUser> _userManager;
        public BookingBookController(AppDBContext context, UserManager<LibraryUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> ChooseSub(int catalogid)
        {
            BookAndSub bs = new BookAndSub();

            bs.CardId = catalogid;
            bs.book = _context.Books.Where(book => book.CatalogCardId == catalogid && book.StatusId == 1).First();

            if(bs.book == null) return NotFound();

            bs.Subscribers = _context.Subscribers;

            if(bs.Subscribers == null) return NotFound();
            return View(bs);
        }
        [HttpGet]
        public async Task<IActionResult> ConfirmChoose(int bookId, int subId, int cardId)
        {
            CatalogCard card = _context.CatalogCards.Find(cardId);
            Subscriber sub = _context.Subscribers.Find(subId);

            ViewBag.BookId = bookId;
            ViewBag.Sub = sub.FullName;
            ViewBag.SubId = subId;
            ViewBag.Card = card.Title;
            ViewBag.CardId = cardId;
            return View("ConfirmChoose");
        }
        [HttpPost]
        public async Task<IActionResult> CreateBooking(int BookId, int SubId, int CardId)
        {

            Booking booking = new Booking();
            booking.BookId = BookId;
            booking.SubscriberId = SubId;
            _context.Add(booking);
            await _context.SaveChangesAsync();

            var book = _context.Books.Find(BookId);
            book.StatusId = 2;
            _context.Update(book);
            await _context.SaveChangesAsync();

            var user = await _userManager.GetUserAsync(HttpContext.User);
            if (await _userManager.IsInRoleAsync(user, "admin") || await _userManager.IsInRoleAsync(user, "librarian"))
                return RedirectToAction("Index", "Bookings");
            else
                return RedirectToAction("Details", "CatalogCard", new { id = CardId });
        }
    }
}
