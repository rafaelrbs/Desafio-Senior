using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PomarManagement.Models
{
    public class Harvest
    {
        public int Id { get; set; }
        public string Information { get; set; }
        public DateTime Dt_harvest { get; set; }
        public float Ps_weight { get; set; }

        public Harvest(int Id, string Information, DateTime Dt_harvest, float Ps_weight)
        {
            this.Id = Id;
            this.Information = Information;
            this.Dt_harvest = Dt_harvest;
            this.Ps_weight = Ps_weight;
        }
    }
}