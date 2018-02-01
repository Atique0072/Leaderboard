namespace LeaderboardAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HeadToHeadContest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HeadToHeadContests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstCommpetitorScore = c.Int(nullable: false),
                        SecondCompetitorScore = c.Int(nullable: false),
                        State = c.Int(nullable: false),
                        Contest_Id = c.Int(),
                        FirstCompetitor_Id = c.Int(),
                        Referee_Id = c.Int(),
                        SecondCompetitor_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Contests", t => t.Contest_Id)
                .ForeignKey("dbo.Competitors", t => t.FirstCompetitor_Id)
                .ForeignKey("dbo.Referees", t => t.Referee_Id)
                .ForeignKey("dbo.Competitors", t => t.SecondCompetitor_Id)
                .Index(t => t.Contest_Id)
                .Index(t => t.FirstCompetitor_Id)
                .Index(t => t.Referee_Id)
                .Index(t => t.SecondCompetitor_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HeadToHeadContests", "SecondCompetitor_Id", "dbo.Competitors");
            DropForeignKey("dbo.HeadToHeadContests", "Referee_Id", "dbo.Referees");
            DropForeignKey("dbo.HeadToHeadContests", "FirstCompetitor_Id", "dbo.Competitors");
            DropForeignKey("dbo.HeadToHeadContests", "Contest_Id", "dbo.Contests");
            DropIndex("dbo.HeadToHeadContests", new[] { "SecondCompetitor_Id" });
            DropIndex("dbo.HeadToHeadContests", new[] { "Referee_Id" });
            DropIndex("dbo.HeadToHeadContests", new[] { "FirstCompetitor_Id" });
            DropIndex("dbo.HeadToHeadContests", new[] { "Contest_Id" });
            DropTable("dbo.HeadToHeadContests");
        }
    }
}
