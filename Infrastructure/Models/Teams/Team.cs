using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Teams
{
    public enum Level
    {
        A,
        B,
        C,
        D
    }

    public enum Sex
    {
        Leány,
        Fiú,
    }

    public class Team : BaseEntity
    {
        //Properties

        public string Name { get; set; } = "";
        public string HomeCourtName { get; set; } = "";
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public string WL { get; set; } = "";
    }
}
