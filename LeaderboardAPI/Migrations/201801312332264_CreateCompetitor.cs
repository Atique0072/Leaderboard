namespace LeaderboardAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    /// <summary>
    /// 
    /// </summary>
    public partial class CreateCompetitor : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Competitors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        /// <summary>
        /// 
        /// </summary>
        public override void Down()
        {
            DropTable("dbo.Competitors");
        }
    }
}
