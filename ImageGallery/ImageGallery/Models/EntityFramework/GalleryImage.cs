using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageGallery.Models.EntityFramework
{
    public class GalleryImage
    {
        public int id { get; set; }
        public string ImageName { get; set; }
        public string ImagePath { get; set; }
        public Gallery Gallery { get; set; }
        public User User { get; set; }

    }
}