using Microsoft.AspNetCore.Mvc;
using IsmtJobportal.Entities;
using IsmtJobportal.Models;
using IsmtJobPorter;
namespace ISMTJobPortal.Controllers
{
    public class UserController : Controller
    {
        JobPortalDbContext dbContext = new JobPortalDbContext();
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(UserViewModel uvm)
        {
            var isUserNameTaken = dbContext.Users.Any(u => u.Username == uvm.Username);
            if (!isUserNameTaken)
            {
                User usr = new User();
                usr.FullName = uvm.FullName;
                usr.Email = uvm.Email;
                usr.Username = uvm.Username;
                usr.Password = uvm.Password;

                dbContext.Users.Add(usr);
                dbContext.SaveChanges();
                ViewBag.Message = "User created for " + uvm.Username;
            }
            else
            {
                ViewBag.Message = "User name already taken!";
            }
            return View();
        }


    }
}