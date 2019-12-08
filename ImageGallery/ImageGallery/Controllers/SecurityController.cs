using ImageGallery.Models.EntityFramework;
using ImageGallery.Models.ImageContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ImageGallery.Controllers
{
    [AllowAnonymous]
    public class SecurityController : Controller
    {
        ImageDbContext db = new ImageDbContext();
        // GET: Security
       
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
            var users = db.Users.FirstOrDefault(x => x.UserName == user.UserName&&x.UserPassword==user.UserPassword);
            if (users!=null)
            {
                FormsAuthentication.SetAuthCookie(users.UserName,false);
                return RedirectToAction("Index", "Gallery");
            }
            else
            {
               
                    ViewBag.Message = "User details wrong";
                
                return View();
            }
           
        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}