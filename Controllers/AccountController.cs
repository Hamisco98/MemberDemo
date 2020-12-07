using MemberDemo.Models.Classes;
using MemberDemo.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemberDemo.Controllers
{
    public class AccountController : Controller
    {

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel model)
        {
            #region
            string Emailx = "hamis@gmail.com";
            string Pass = "a_2737417";
            #endregion
            if (ModelState.IsValid)
            {
                
                if (model.Email == Emailx && model.Password == Pass)
                {
                    return RedirectToAction("Dashboard", "Admin");
                }
                ModelState.AddModelError(string.Empty, "Invalid Login");
            }

            return View(model);
        }
    }
}
