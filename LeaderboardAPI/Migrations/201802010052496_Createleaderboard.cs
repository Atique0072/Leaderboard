namespace LeaderboardAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Createleaderboard : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leaderboards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameId = c.Int(nullable: false),
                        CompetitorId = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Competitors", t => t.CompetitorId, cascadeDelete: true)
                .ForeignKey("dbo.Games", t => t.GameId, cascadeDelete: true)
                .Index(t => t.GameId)
                .Index(t => t.CompetitorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Leaderboards", "GameId", "dbo.Games");
            DropForeignKey("dbo.Leaderboards", "CompetitorId", "dbo.Competitors");
            DropIndex("dbo.Leaderboards", new[] { "CompetitorId" });
            DropIndex("dbo.Leaderboards", new[] { "GameId" });
            DropTable("dbo.Leaderboards");
        }
    }
}
