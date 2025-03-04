using Infrastructure.Models.Base;
using Infrastructure.Models.Matches;
using Infrastructure.Models.Payments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Ref
{
    public enum Badge
    {
        Rookie,
        Megyei,
        NB2,
        NB1
    }

    [PrimaryKey("Id")]
    public class Referee : BaseEntity
    {               
        //Properties
        //az Id meg a Deleted propertiket a BaseEntitytől megkapta, ezért nem kellett itt most újra létrehozni
        //egy referee példánnyal ez csekkolható is
        
        public string Name { get; set; } = "";  //ref tipusu es lehet ugye null ezt ki lehet zarni azzal ha erteke adsz neki vagy ? teszel
        public string ?Address { get; set; }
        public List<DateTime> WorkTime { get; set; } = new List<DateTime>();
        public Badge Rank { get; set; }
        public bool Licence { get; set; }
        public List<string> Info { get; set; } = new List<string>();

        //navigetion properties
        //virtual ez a lazy loadinghoz kell
        public virtual List<Match> Matchies { get; set; } = new List<Match>();
        public virtual List<Payment> Payments { get; set; } = new List<Payment>();

       
    }
}
