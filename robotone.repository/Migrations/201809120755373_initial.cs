namespace RobotOne.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Phase = c.String(maxLength: 200),
                        Description = c.String(),
                        GroupId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(maxLength: 50),
                        Modified = c.DateTime(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        Name = c.String(maxLength: 50),
                        Description = c.String(),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(maxLength: 50),
                        Modified = c.DateTime(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(maxLength: 50),
                        Modified = c.DateTime(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Email = c.String(maxLength: 200),
                        Role = c.String(maxLength: 200),
                        GroupId = c.Int(nullable: false),
                        CreatedBy = c.String(nullable: false, maxLength: 50),
                        Created = c.DateTime(nullable: false),
                        ModifiedBy = c.String(maxLength: 50),
                        Modified = c.DateTime(),
                        IsEnabled = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GroupId, cascadeDelete: true)
                .Index(t => t.GroupId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Bots", "GroupId", "dbo.Groups");
            DropIndex("dbo.Users", new[] { "GroupId" });
            DropIndex("dbo.Bots", new[] { "GroupId" });
            DropTable("dbo.Users");
            DropTable("dbo.Logs");
            DropTable("dbo.Groups");
            DropTable("dbo.Bots");
        }
    }
}
