using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PomarManagement.Models;

namespace PomarManagement.Controllers
{
    public class gr_TreeController : ApiController
    {
        private static List<gr_Tree>  gr_Tree = new List<gr_Tree>();

        public List<gr_Tree> Get()
        {
            return gr_Tree;
        }

        public void Post(int Id, string Name, string Description, int Tree)
        {
            //    if (!string.IsNullOrEmpty(nome))
            gr_Tree.Add(new gr_Tree(Id, Name, Description, Tree));
        }
    }
}
