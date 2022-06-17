namespace LabBigSchool_KhangVy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCouser : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        Name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Cousers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        LecturerId = c.String(nullable: false, maxLength: 128),
                        Place = c.String(nullable: false, maxLength: 255),
                        DateTime = c.DateTime(nullable: false),
                        CategoryId = c.Byte(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.LecturerId, cascadeDelete: true)
                .Index(t => t.LecturerId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cousers", "LecturerId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Cousers", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Cousers", new[] { "CategoryId" });
            DropIndex("dbo.Cousers", new[] { "LecturerId" });
            DropTable("dbo.Cousers");
            DropTable("dbo.Categories");
        }
    }
}
