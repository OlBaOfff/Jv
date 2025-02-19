using Infrastructure.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Models.Ref
{
    public class Referee:BaseEntity
    {
        //fields

        private int id;
        private string name;
        private string address;
        private List<DateTime> workTime;
        private string rang;
        private bool licence;
        private List<string> info;

        //ctor
        public Referee(int id, string name, string address, List<DateTime> workTime, string rang, bool licence, List<string> info)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.WorkTime = workTime;
            this.Rang = rang;
            this.Licence = licence;
            this.Info = info;
        }

        //Properties
        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public List<DateTime> WorkTime { get => workTime; set => workTime = value; }
        public string Rang { get => rang; set => rang = value; }
        public bool Licence { get => licence; set => licence = value; }
        public List<string> Info { get => info; set => info = value; }
    }
}
