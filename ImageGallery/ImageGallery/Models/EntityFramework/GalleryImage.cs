using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageGallery.Models.EntityFramework
{
    public class GalleryImage
    {
        public int Id { get; set; }
        [Display(Name ="Image Name")]
        public string ImageName { get; set; }
        [Display(Name ="Image Path")]
        public string ImagePath { get; set; }
        public Gallery Gallery { get; set; }
        public User User { get; set; }

    }
}