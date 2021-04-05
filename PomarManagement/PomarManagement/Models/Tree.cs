using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PomarManagement.Models
{
    public class Tree
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public string Specie { get; set; }


        public Tree(string Description, string Name, int Id, string Specie)
        {
            this.Description = Description;
            this.Name = Name;
            this.Id = Id;
            this.Specie = Specie;

        }
    }

}