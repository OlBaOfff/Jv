using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Base
{
    public abstract class BaseEntity
    {
        //Properties
        [Key] //nem szükséges, mert az EF felismeri az ID vagy UserID hogy az egy kulcs lesz
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //legenerálja az értékeket nekünk az EF az adatbázisnál
        public int Id { get; set; }

        public bool Deleted { get; set; }


    }
}
