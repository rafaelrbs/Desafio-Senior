using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using PomarManagement.Models;


namespace PomarManagement.Controllers
{
    public class SpeciesController : ApiController
    {
        private static List<Species> Species = new List<Species>();

        public List<Species> Get()
        {
            return Species;
        }

        public void Post(string Description, int Id)
        {
            //    if (!string.IsNullOrEmpty(nome))
            Species.Add(new Species(Description,  Id));
        }
    }
}
