using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kimtaehoo1.Models;

namespace Kimtaehoo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var KimUser = new User
            {
                UserNo = 1,
                UserName = "김태후"
            };
            // #첫번째 방식 View(model);
            // return View(KimUser);

            // #두번째 방식 ViewBag
            ViewBag.User = KimUser;

            // #세번째 방식 ViewData
            ViewData["UserNo"] = KimUser.UserNo;
            ViewData["UserName"] = KimUser.UserName;
            return View(KimUser);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
