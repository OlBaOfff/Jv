using Infrastructure.Models.Base;
using Infrastructure.Models.Ref;
using Infrastructure.Models.Teams;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Matches
{
    public enum Level
    {
        Easy,
        Medium,
        Hard,
        Veteran

    }
    [PrimaryKey("Id")]
    class Match:BaseEntity
    {
        //Properties

        public string Location { get; set; } = "";
        public DateTime Start { get; set; }
        public Level Difficulty { get; set; }
        public int Fee { get; set; }
        public string Colleagues { get; set; } = "";
        public int HomeTeamId { get; set; }
        public int GuestTeamId { get; set; }

        //nav properties

        public virtual List<Team> Teams { get; set; } = new List<Team>();
        public virtual List<Referee> Referees { get; set; } = new List<Referee>();
    }
}
