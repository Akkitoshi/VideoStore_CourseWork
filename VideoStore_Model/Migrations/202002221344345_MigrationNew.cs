namespace VideoStore_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationNew : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClientCards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        PassportNumber = c.String(),
                        Penalties = c.Int(nullable: false),
                        Frequency = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ClientContracts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        ProductAmount = c.Int(nullable: false),
                        SummaryPrice = c.Int(nullable: false),
                        DateOfConclusion = c.DateTime(nullable: false),
                        RentalPeriodEnd = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ClientCards", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ClientId)
                .Index(t => t.UserId)
                .Index(t => t.ServiceId)
                .Index(t => t.ProductId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Price = c.Int(nullable: false),
                        CountContracts = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FIO = c.String(),
                        Role = c.String(),
                        Position = c.String(),
                        Login = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClientContracts", "UserId", "dbo.Users");
            DropForeignKey("dbo.ClientContracts", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ClientContracts", "ProductId", "dbo.Products");
            DropForeignKey("dbo.ClientContracts", "ClientId", "dbo.ClientCards");
            DropIndex("dbo.ClientContracts", new[] { "ProductId" });
            DropIndex("dbo.ClientContracts", new[] { "ServiceId" });
            DropIndex("dbo.ClientContracts", new[] { "UserId" });
            DropIndex("dbo.ClientContracts", new[] { "ClientId" });
            DropTable("dbo.Users");
            DropTable("dbo.Services");
            DropTable("dbo.Products");
            DropTable("dbo.ClientContracts");
            DropTable("dbo.ClientCards");
        }
    }
}
