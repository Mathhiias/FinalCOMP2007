using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinalA.Models
{
    public class EFTeamRepository : ITeamRepository
    {
        HockeyModel db = new HockeyModel();
        public IQueryable<Team> Teams { get { return db.Teams; } }   
    }
}