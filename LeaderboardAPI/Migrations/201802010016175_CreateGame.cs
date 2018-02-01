namespace LeaderboardAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    /// <summary>
    /// 
    /// </summary>
    public partial class CreateGame : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            Sql("INSERT INTO Games VALUES ('Karate')");
            Sql("INSERT INTO Games VALUES ('Tennis')");
            Sql("INSERT INTO Games VALUES ('Badminton')");
            Sql("INSERT INTO Games VALUES ('TableTennis')");


        }
        /// <summary>
        /// 
        /// </summary>
        public override void Down()
        {
            DropTable("dbo.Games");
        }
    }
}
