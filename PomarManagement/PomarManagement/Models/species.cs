using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PomarManagement.Models
{
    public class Species
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Species(string Description,  int Id)
        {
            this.Description = Description;
            this.Id = Id;
            //  this.Specie = Species;

        }
    }
}