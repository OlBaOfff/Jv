using Infrastructure.Models.Payments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class PaymentRepositrory : BaseRepository<Payment>
    {
        public PaymentRepositrory(Infrastructure.DbCont.DbCont context) : base(context)
        {

        }

        public override IQueryable<Payment> WithInClude()
        {
            return base.WithInClude()
                .Include(x => x.Referees);
        }
    }
}
