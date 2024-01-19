using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TheGioiBiDong.Data;
using TheGioiBiDong.Models;

namespace TheGioiBiDong.Controllers
{
    public class HomeController : Controller
    {
		private readonly TheGioiBiDongContext _context;

		public HomeController(TheGioiBiDongContext context)
        {
			_context = context;
		}

		// GET: Products
		public async Task<IActionResult> Index()
		{
			var products = await _context.Products.Include(p => p.Brand).Include(p => p.Categories).ToListAsync();
			return View(products);
		}


		public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
