using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopSim.Web.Models
{
    public class SimNetworkViewModel
    {
        public int ID { set; get; }

        public string Name { set; get; }
        
        public string Alias { set; get; }

        public string Image { set; get; }

        public string Description { set; get; }

        public string MetaDescription { set; get; }

        public string MetaKeywork { set; get; }
        
        public Boolean Status { set; get; }
        
        public Boolean HomeFlag { set; get; }

        public virtual IEnumerable<FirstNumberViewModel> FirstNumbers { set; get; }
    }
}