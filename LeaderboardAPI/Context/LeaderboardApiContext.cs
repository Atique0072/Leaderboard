using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LBDomain.Models;
namespace LeaderboardAPI.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class LeaderboardApiContext:DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public LeaderboardApiContext():base("DefaultConnection")
        {

        }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Competitor> Competitor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Game> Game { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Referee> Referee { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Contest> Contest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<HeadToHeadContest> HeadToHeadContest { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DbSet<Leaderboard> Leaderboard { get; set; }

    }
}