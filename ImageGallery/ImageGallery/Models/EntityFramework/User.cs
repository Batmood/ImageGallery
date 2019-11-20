using System;
using System.Collections.Generic;
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
        public int id { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPassword { get; set; }
        public IEnumerable<GalleryImage> GalleryImages { get; set; }
        public IEnumerable<Gallery> Galleries { get; set; }
    }
}