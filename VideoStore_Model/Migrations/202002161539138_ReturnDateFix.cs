namespace VideoStore_Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReturnDateFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ClientContracts", "ReturnDate", c => c.DateTime(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ClientContracts", "ReturnDate", c => c.DateTime(nullable: false));
        }
    }
}
