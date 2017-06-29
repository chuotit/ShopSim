using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSim.Web.Models
{
    public class FirstNumberViewModel
    {
        public int ID { set; get; }

        public int NetworkID { set; get; }

        public virtual SimNetworkViewModel SimNetwork { set; get; }

        public int Number { set; get; }
    }
}