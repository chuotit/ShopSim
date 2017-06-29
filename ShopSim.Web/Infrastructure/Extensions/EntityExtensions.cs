using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ShopSim.Model.Models;
using ShopSim.Web.Models;

namespace ShopSim.Web.Infrastructure.Extensions
{
    static class EntityExtensions
    {
        public static void UpdateSimNetwork(this SimNetwork simNetwork, SimNetworkViewModel simNetworkViewModel)
        {
            simNetwork.ID = simNetworkViewModel.ID;
            simNetwork.Name = simNetworkViewModel.Name;
            simNetwork.Alias = simNetworkViewModel.Alias;
            simNetwork.Image = simNetworkViewModel.Image;
            simNetwork.Description = simNetworkViewModel.Description;
            simNetwork.MetaKeywork = simNetworkViewModel.MetaKeywork;
            simNetwork.MetaDescription = simNetworkViewModel.MetaDescription;
            simNetwork.HomeFlag = simNetworkViewModel.HomeFlag;
            simNetwork.Status = simNetworkViewModel.Status;
        }

        static void UpdateFirstNumber(this FirstNumber firstNumber, FirstNumberViewModel firstNumberViewModel)
        {
            firstNumber.ID = firstNumberViewModel.ID;
            firstNumber.NetworkID = firstNumberViewModel.NetworkID;
            firstNumber.Number = firstNumberViewModel.Number;
        }
    }
}