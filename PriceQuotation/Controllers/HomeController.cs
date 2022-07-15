using Microsoft.AspNetCore.Mvc;
using PriceQuotation.Models;
using System;
using PriceQuotation.Services;

namespace PriceQuotation.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.DiscountAmount = 0;
            ViewBag.Total = 0;

            return View();
        }
        
        [HttpPost]
        public IActionResult Index(Quotation quotation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    ViewBag.DiscountAmount = quotation.GetDiscountAmount();
                    ViewBag.Total = quotation.GetTotalAmount();
                }
                else
                {
                    ViewBag.DiscountAmount = 0;
                    ViewBag.Total = 0;
                }
                return View(quotation);
            }
            catch(Exception e)
            {
                ViewBag.error = e;
                return View("Error");
            }

        }      
    }
}
