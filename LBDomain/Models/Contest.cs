using System.Collections.Generic;

namespace LBDomain
{
    namespace Models
    {
        public class Contest
        {
            public readonly List<Competitor> Competitor = new List<Models.Competitor>();
            public int Id { get; set; }
            public Game Game { get; set; }
            public List<Competitor> Competitors { get; set; }
        }
    }
}
