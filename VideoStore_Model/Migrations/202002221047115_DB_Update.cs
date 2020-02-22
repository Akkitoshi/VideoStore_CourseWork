namespace VideoStore_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "CountContracts", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "CountContracts");
        }
    }
}
