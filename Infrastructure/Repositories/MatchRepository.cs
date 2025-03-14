using Infrastructure.Models.Matches;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class MatchRepository : BaseRepository<Match>
    {
        public MatchRepository(Infrastructure.DbCont.DbCont context) : base(context)
        {

        }

        public override IQueryable<Match> WithInClude()
        {
            return base.WithInClude()
                .Include(x => x.Teams)
                .Include(y => y.Referees);
        }
    }
}
