using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TheGioiBiDong.Data;

namespace TheGioiBiDong.Controllers
{
	[ViewComponent(Name = "_Category")]
	public class _CategoryViewComponent:ViewComponent
	{
		private readonly TheGioiBiDongContext _context;

		public _CategoryViewComponent(TheGioiBiDongContext context)
		{
			_context = context;
		}

		public IViewComponentResult Invoke()
		{
			var _category = _context.Categories.ToList();
			return View("Categories", _category);

		}
	}
}
