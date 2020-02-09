namespace VideoStore_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdDbModel2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Name", c => c.String());
            DropColumn("dbo.Products", "ClientContractId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "ClientContractId", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "Name");
        }
    }
}
