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
        [Key]
        public int id { get; set; }
        public string CoverName { get; set; }
        public string CoverPath { get; set; }
        public User User { get; set; }
        public IEnumerable<GalleryImage> GalleryImages { get; set; }
    }
}