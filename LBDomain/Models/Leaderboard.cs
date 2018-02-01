using System;
namespace LBDomain
{
    namespace Models
    {
        public class Leaderboard
        {
            public int Id { get; set; }
            public int GameId { get; set; }
            public Game Game { get; set; }
            public int CompetitorId { get; set; }
            public Competitor Competitor { get; set; }
            public int Score { get; set; }

            public DateTime DateTime { get; set; }
        }
    }
}
