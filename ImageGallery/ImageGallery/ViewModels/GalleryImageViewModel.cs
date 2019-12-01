using ImageGallery.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageGallery.ViewModels
{
    public class GalleryImageViewModel
    {
        public IEnumerable<GalleryImage> GalleryImages { get; set; }
        public User User { get; set; }
        public GalleryImageViewModel()
        {

        }
    }
}