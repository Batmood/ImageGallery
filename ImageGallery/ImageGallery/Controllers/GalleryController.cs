using ImageGallery.Models.EntityFramework;
using ImageGallery.Models.ImageContext;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageGallery.Controllers
{
    public class GalleryController : Controller
    {
        ImageDbContext db = new ImageDbContext();
        
        [AllowAnonymous]
        public ActionResult Index()
        {
            var coverImage = db.Galleries.ToList();
            return View(coverImage);
        }
        
        public ActionResult CoverUpload()
        {
            ViewData["error"] = "";
            return View();
        }

        [HttpPost]
        public ActionResult CoverUpload(Gallery CoverPicture, HttpPostedFileBase CoverPath)
        {
            try
            {
                Gallery coverImage = new Gallery();
                coverImage.CoverName = CoverPicture.CoverName;
                coverImage.CoverPath = CoverPath.FileName.ToString();

                var path = Server.MapPath("~/Content/CoverImages");
                CoverPath.SaveAs(Path.Combine(path, CoverPath.FileName.ToString()));
                db.Galleries.Add(coverImage);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                ViewData["error"] = "Error for Upload";
                return View();
            }
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int id)
        {
            var gallery = db.Galleries.Find(id);
            if (gallery==null)
            {
                return HttpNotFound();
            }
            db.Galleries.Remove(gallery);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}