using Infrastructure.GenericRepository;
using Infrastructure.Models.Ref;
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
           
            return base.WithInClude();
        }
    }
}
