using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using FinalA.Models;
using System.Runtime.InteropServices.ComTypes;

namespace FinalA.Controllers
{
    public class TeamsController : Controller
    {
        private ITeamRepository db;

        public TeamsController()
        {
            this.db = new EFTeamRepository();
        }

        public TeamsController(ITeamRepository mockRepo)
        {
            this.db = mockRepo;
        }

        [Authorize]
        // GET: Teams
        public ViewResult Index()
        {
            var teams = db.Teams.Include(t => t.Division);
            return View(teams.ToList());
        }

        // GET: Teams/Details/5
        public ViewResult Details(int? id)
        {
            if (id == null)
            {
                return View("Error");
            }
            Team team = db.Teams.SingleOrDefault(t => t.TeamID == id);

            if (team == null)
            {
                return View("Error");
            }
            return View(team);
        }
    }
}
