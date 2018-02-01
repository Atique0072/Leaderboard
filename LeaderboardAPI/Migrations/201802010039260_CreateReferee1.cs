namespace LeaderboardAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateReferee1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Referees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Referees");
        }
    }
}
