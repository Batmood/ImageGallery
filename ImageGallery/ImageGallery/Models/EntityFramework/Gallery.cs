using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ImageGallery.Models.EntityFramework
{
    public class Gallery
    {
        public Gallery()
        {
            GalleryImages = new List<GalleryImage>();
        }
        
        public int Id { get; set; }
        [Display(Name ="Gallery Name")]
        public string CoverName { get; set; }
        [Display(Name ="Gallery Path")]
        public string CoverPath { get; set; }
        public User User { get; set; }
        public List<GalleryImage> GalleryImages { get; set; }
    }
}