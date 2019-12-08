using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageGallery.Models.EntityFramework
{
    public class User
    {
        public User()
        {
            GalleryImages = new List<GalleryImage>();
            Galleries = new List<Gallery>();
        }
        public int Id { get; set; }
        [Display(Name ="User Name")]
        public string UserName { get; set; }
        [Display(Name ="User E-mail")]
        public string UserEmail { get; set; }
        [Display(Name ="Password")]
        public string UserPassword { get; set; }
        public List<GalleryImage> GalleryImages { get; set; }
        public List<Gallery> Galleries { get; set; }
    }
}