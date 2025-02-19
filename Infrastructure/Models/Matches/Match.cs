using Infrastructure.Models.Base;
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
    }
}
