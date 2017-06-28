using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShopSim.Web.API
{
    public class TestController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new string[] { "String 1", "String 2" };
        }
    }
}
