using TheGioiBiDong.Models;
using Microsoft.AspNetCore.Mvc;
using TheGioiBiDong.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace TheGioiBiDong.Controllers
{
    public class AccountController : Controller
    {
        private readonly TheGioiBiDongContext _context;

        public AccountController(TheGioiBiDongContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Users _userFromPage)
        {
            var _user = _context.Users.Where(m=>m.UserEmail == _userFromPage.UserEmail && m.UserPassword == _userFromPage.UserPassword).FirstOrDefault();
            if(_user == null) 
            {
                ViewBag.LoginStatus = 0;
            }
            else
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, _user.UserEmail),
                    new Claim("FullName", _user.UserName),
                    new Claim(ClaimTypes.Role, _user.UserRole),
                };

                var claimsIdentity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var authProperties = new AuthenticationProperties
                {
                };

                    HttpContext.SignInAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity),
                    authProperties);

                return RedirectToAction("Index","Account");
            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(
            CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}
