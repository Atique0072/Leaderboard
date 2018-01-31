using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
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
    }
}