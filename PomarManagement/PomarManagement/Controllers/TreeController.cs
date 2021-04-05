using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PomarManagement.Models;

namespace PomarManagement.Controllers
{
    public class TreeController : ApiController
    {
        private static List<Tree> Tree = new List<Tree>();

        public List<Tree> Get()
        {
            return Tree;
        }

        public void Post(string Description, string Name, int Id, string Specie)
        {
        //    if (!string.IsNullOrEmpty(nome))
                Tree.Add(new Tree(Description, Name, Id, Specie));
        }


    }
}
