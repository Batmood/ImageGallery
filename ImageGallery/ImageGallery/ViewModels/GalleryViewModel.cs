using ImageGallery.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageGallery.ViewModels
{
    public class GalleryViewModel
    {
        public IEnumerable<Gallery> Galleries { get; set; }
        public User Users { get; set; }
    }
}