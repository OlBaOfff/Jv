using Infrastructure.Models.Teams;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class TeamRepository : BaseRepository<Team>
    {
        public TeamRepository(Infrastructure.DbCont.DbCont context) : base(context)
        {

        }

        public override IQueryable<Team> WithInClude()
        {
            return base.WithInClude()
                .Include(x => x.Matchies);
        }
    }
}
