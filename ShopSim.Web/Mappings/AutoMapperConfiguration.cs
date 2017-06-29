using AutoMapper;
using ShopSim.Model.Models;
using ShopSim.Web.Models;

namespace ShopSim.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.CreateMap<SimNetwork, SimNetworkViewModel>();
            Mapper.CreateMap<FirstNumber, FirstNumberViewModel>();
        }

    }
}