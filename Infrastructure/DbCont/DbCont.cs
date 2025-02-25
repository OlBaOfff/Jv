using Infrastructure.Models.Payments;
using Infrastructure.Models.Ref;
using Infrastructure.Models.Teams;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infrastructure.DbCont
{
    public class DbCont:DbContext
    {
        //táblák létrehozása az adatbázisban
        
        public DbSet<Match> Matchies { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Referee> Referees { get;set; }
        public DbSet<Team> Teams { get; set; }

    }
}
