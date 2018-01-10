using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalA.Models
{
    public interface ITeamRepository
    {
        IQueryable<Team> Teams { get; }
    }
}
