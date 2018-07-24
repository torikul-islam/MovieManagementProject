namespace MovieHunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsSubscribeToNewslatter : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubscribedToNewsletter", n => n.Boolean(nullable:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customer", "IsSubscribedToNewsletter");
        }
    }
}
