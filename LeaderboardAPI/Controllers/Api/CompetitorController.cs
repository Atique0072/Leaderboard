using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using LeaderboardAPI.Context;
using LBDomain.Models;

namespace LeaderboardAPI.Controllers.Api
{
    /// <summary>
    /// 
    /// </summary>
    public class CompetitorController : ApiController
    {
        private LeaderboardApiContext _context;
        /// <summary>
        /// 
        /// </summary>
        public CompetitorController()
        {
            _context = new LeaderboardApiContext();
        }
        //GET /api/Competitors
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Competitor> GetCompetitors()
        {
            return _context.Competitor.ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        //GET /api/Competitor/1
        public Competitor GetCompetitor(int id)
        {
            var competitor = _context.Competitor.SingleOrDefault(c => c.Id == id);

            if (competitor == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return competitor;
        }

        //POST /api/competitor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="competitor"></param>
        /// <returns></returns>
        [HttpPost]
        public Competitor CreateCompetitor(Competitor competitor)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Competitor.Add(competitor);
            _context.SaveChanges();

            return competitor;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <param name="competitor"></param>
        //PUT /api/competitor/1
        [HttpPut]
        public void UpdateCompetitor(int id, Competitor competitor)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var competitorInDb = _context.Competitor.SingleOrDefault(c => c.Id == id);

            if (competitorInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            competitorInDb.FirstName = competitor.FirstName;
            competitorInDb.LastName = competitor.LastName;
            competitorInDb.EmailId = competitorInDb.EmailId;

            _context.SaveChanges();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        //DELETE /api/competitor/1
        [HttpDelete]
        public void DeleteCompetitor(int id)
        {
            var competitorInDb = _context.Competitor.SingleOrDefault(c => c.Id == id);

            if (competitorInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Competitor.Remove(competitorInDb);
            _context.SaveChanges();
        }
    }
}
