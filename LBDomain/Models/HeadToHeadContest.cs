namespace LBDomain
{
    namespace Models
    {
        public class HeadToHeadContest
        {
            public int Id { get; set; }
            public Competitor FirstCompetitor { get; set; }
            public int FirstCommpetitorScore { get; set; }
            public Competitor SecondCompetitor { get; set; }
            public int SecondCompetitorScore { get; set; }
            public Contest Contest { get; set; }
            public Referee Referee { get; set; }
            public State State { get; set; }
        }
    }
}
