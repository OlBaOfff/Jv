using Infrastructure.GenericRepository;
using Infrastructure.Models.Ref;
using Infrastructure.Models.Teams;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class RefereeRepository:BaseRepository<Referee>
    {
        
        
        public RefereeRepository(Infrastructure.DbCont.DbCont context) : base(context)
        {
                
        }

        public override IQueryable<Referee> WithInClude()
        {
            //base.WithInClude == _context.Set<T>()
            //base az osnek (os itt a BaseRepository) a WithInclude metodussat hasznalja ami visszaadja a _context.Set<T>
            return base.WithInClude()
                .Include(r => r.Matchies)
                .Include(t => t.Payments);
        }
    }
}
