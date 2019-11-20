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
    public class ImageController : Controller
    {
        ImageDbContext db = new ImageDbContext();
        // GET: Image
        public ActionResult Index()
        {
            var model = db.GaleryImages.ToList();
            return View(model);
        }
        public ActionResult Upload()
        {
            ViewData["error"] = "";
            return View();
        }
        [HttpPost]
        public ActionResult Upload(GalleryImage img,HttpPostedFileBase ImagePath)
        {
            try
            {
                GalleryImage image = new GalleryImage();
                image.ImageName = img.ImageName;
                image.ImagePath = ImagePath.FileName.ToString();

                var path = Server.MapPath("~/Content/Images");
                ImagePath.SaveAs(Path.Combine(path, ImagePath.FileName.ToString()));
                db.GaleryImages.Add(image);
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                ViewData["error"] = "Error for Upload";
                return View();
            }
            return RedirectToAction("Index");
            
        }
    }
}