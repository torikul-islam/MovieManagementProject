namespace MovieHunt.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieInModel : DbMigration
    {
        public override void Up()
        {
            CreateTable("dbo.Movies", m => new
                {
                    Id = m.Int(nullable: false, identity:true),
                    Name = m.String()

                })
                .PrimaryKey(p => p.Id);
        }
        
        public override void Down()
        {
           DropTable("dbo.Movies");
        }
    }
}
