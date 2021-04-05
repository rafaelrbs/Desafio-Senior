using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PomarManagement.Models;

namespace PomarManagement.Controllers
{
    public class HarvestController : ApiController
    {
        private static List<Harvest> Harvest = new List<Harvest>();

        public List<Harvest> Get()
        {
            return Harvest;
        }

        public void Post(int Id, string Information, DateTime Dt_harvest, float Ps_weight)
        {
            //    if (!string.IsNullOrEmpty(nome))
            Harvest.Add(new Harvest(Id, Information, Dt_harvest, Ps_weight));
        }
    }
}
