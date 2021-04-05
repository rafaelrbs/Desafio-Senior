using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PomarManagement.Models
{
    public class gr_Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Tree { get; set; }

        public gr_Tree(int Id, string Name, string Description, int Tree)
        {
            this.Id = Id;
            this.Name = Name;
            this.Description = Description;
            this.Tree = Tree;
            
            //  this.Specie = Species;

        }
    }


    
}