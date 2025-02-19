using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Payments
{
    public enum PaymentType
    {
        Kézpénz,
        Utalás,
        Központi
    }
    class Payment:BaseEntity
    {
        //Properties

        public int JvId { get; set; }
        public int Amount { get; set; }
        public List<int> MatchesId { get; set; } = new List<int>();
        public PaymentType PaymentType { get; set; }
    }
}
