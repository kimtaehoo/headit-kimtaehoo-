using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web.Providers.Entities;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kimtaehoo_hompage.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpGet] 
        public IActionResult Login() // 로그인
        {
            return View();
        }
 
        public IActionResult Register() //회원가입
        {
            return View();
        }
    }
}
