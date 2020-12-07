using MemberDemo.Models.Classes;
using MemberDemo.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using MemberDemo.Models.ViewModels;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Authorization;

namespace MemberDemo.Controllers
{
    public class AdminController : Controller
    {
        private readonly IMember member;
        private readonly IWebHostEnvironment hostingEnvironment;

        public AdminController(IMember member,
                                IWebHostEnvironment hostingEnvironment)
        {
            this.member = member;
            this.hostingEnvironment = hostingEnvironment;
        }
        [Authorize]
        public IActionResult Dashboard()
        {
            var model = member.GetAll();
            return View(model);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Create(MemberViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string uniqueFileName = null;
                    if (model.Photo != null) 
                    {
                        string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Imgs");
                        uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Photo.FileName;
                        string FilePath = Path.Combine(uploadFolder, uniqueFileName);
                        model.Photo.CopyTo(new FileStream(FilePath, FileMode.Create));
                    }


                    Member newMember = new Member
                    {
                        FirstName = model.FirstName,
                        LastName = model.LastName,
                        Country = model.Country,
                        City = model.City,
                        Gender = model.Gender,
                        PhoneNumber = model.PhoneNumber,
                        Email = model.Email,
                        Notes = model.Notes,
                        MemberStatus = model.MemberStatus,
                        Photo = uniqueFileName
                    };
                    member.Add(newMember);
                    return RedirectToAction(nameof(Dashboard));
                }
            }
            catch (Exception)
            {

                throw;
            }
            return View(member);
        }
    }
}
