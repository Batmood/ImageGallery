using ImageGallery.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ImageGallery.Models.ImageContext
{
    public class ImageDbContext:DbContext
    {
        public ImageDbContext():base("ImageGalleryConStr")
        {

        }
        public DbSet<GalleryImage> GaleryImages { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<User> Users { get; set; }
    }
}