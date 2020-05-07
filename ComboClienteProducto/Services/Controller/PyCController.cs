using BusinessLogic;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Services.Controller
{
    public class PyCController : ApiController
    {
        // GET: api/PyC
        public IEnumerable<Product> GetP()
        {
            return Manager.acquireProduct();
        }

        // GET: api/PyC/5
        public IEnumerable<Client> GetCli()
        {
            return Manager.acquireClient();
        }

        public IEnumerable<Combos> GetComb()
        {
            return Manager.acquireCombo();
        }

    }
}
