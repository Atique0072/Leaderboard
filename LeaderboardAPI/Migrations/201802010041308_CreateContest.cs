namespace LeaderboardAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateContest : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Game_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.Game_Id)
                .Index(t => t.Game_Id);
            
            AddColumn("dbo.Competitors", "Contest_Id", c => c.Int());
            CreateIndex("dbo.Competitors", "Contest_Id");
            AddForeignKey("dbo.Competitors", "Contest_Id", "dbo.Contests", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contests", "Game_Id", "dbo.Games");
            DropForeignKey("dbo.Competitors", "Contest_Id", "dbo.Contests");
            DropIndex("dbo.Contests", new[] { "Game_Id" });
            DropIndex("dbo.Competitors", new[] { "Contest_Id" });
            DropColumn("dbo.Competitors", "Contest_Id");
            DropTable("dbo.Contests");
        }
    }
}
