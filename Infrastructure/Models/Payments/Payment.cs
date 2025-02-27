using Infrastructure.Models.Base;
using Infrastructure.Models.Ref;
using Microsoft.EntityFrameworkCore;
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
    [PrimaryKey("Id")]
    public class Payment:BaseEntity
    {
        //Properties
       
        public int JvId { get; set; }
        public int Amount { get; set; }
        public List<int> MatchesId { get; set; } = new List<int>();
        public PaymentType PaymentType { get; set; }

        //nav properties

        public virtual List<Referee> Referee { get; set; } = new List<Referee>();
    }
}
