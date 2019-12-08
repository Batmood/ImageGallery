namespace ImageGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Databaseupdated : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.GalleryImages", new[] { "Gallery_id" });
            DropIndex("dbo.GalleryImages", new[] { "User_id" });
            DropIndex("dbo.Galleries", new[] { "User_id" });
            CreateIndex("dbo.GalleryImages", "Gallery_Id");
            CreateIndex("dbo.GalleryImages", "User_Id");
            CreateIndex("dbo.Galleries", "User_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Galleries", new[] { "User_Id" });
            DropIndex("dbo.GalleryImages", new[] { "User_Id" });
            DropIndex("dbo.GalleryImages", new[] { "Gallery_Id" });
            CreateIndex("dbo.Galleries", "User_id");
            CreateIndex("dbo.GalleryImages", "User_id");
            CreateIndex("dbo.GalleryImages", "Gallery_id");
        }
    }
}
