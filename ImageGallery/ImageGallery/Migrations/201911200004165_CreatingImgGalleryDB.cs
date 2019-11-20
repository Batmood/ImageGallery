namespace ImageGallery.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatingImgGalleryDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GalleryImages",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        ImageName = c.String(),
                        ImagePath = c.String(),
                        Gallery_id = c.Int(),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Galleries", t => t.Gallery_id)
                .ForeignKey("dbo.Users", t => t.User_id)
                .Index(t => t.Gallery_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        CoverName = c.String(),
                        CoverPath = c.String(),
                        User_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Users", t => t.User_id)
                .Index(t => t.User_id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        UserEmail = c.String(),
                        UserPassword = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.GalleryImages", "User_id", "dbo.Users");
            DropForeignKey("dbo.GalleryImages", "Gallery_id", "dbo.Galleries");
            DropForeignKey("dbo.Galleries", "User_id", "dbo.Users");
            DropIndex("dbo.Galleries", new[] { "User_id" });
            DropIndex("dbo.GalleryImages", new[] { "User_id" });
            DropIndex("dbo.GalleryImages", new[] { "Gallery_id" });
            DropTable("dbo.Users");
            DropTable("dbo.Galleries");
            DropTable("dbo.GalleryImages");
        }
    }
}
