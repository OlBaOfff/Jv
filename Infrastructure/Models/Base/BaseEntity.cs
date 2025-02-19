using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Base
{
    public abstract class BaseEntity
    {
        //Properties
        public int Id { get; set; }

        public bool Deleted { get; set; }


    }
}
