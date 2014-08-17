namespace BookService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTestProperty : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Books", "test");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Books", "test", c => c.String());
        }
    }
}
