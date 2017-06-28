using System.Collections.Generic;
using System.Linq;
using ShopSim.Data.Infrastructure;
using ShopSim.Model.Models;

namespace ShopSim.Data.Repositories
{
    public interface ISimNetworkRepository : IRepository<SimNetwork>
    {
        IEnumerable<SimNetwork> GetByAlias(string alias);
    }

    internal class SimNetworkRepository : RepositoryBase<SimNetwork>, ISimNetworkRepository
    {
        public SimNetworkRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<SimNetwork> GetByAlias(string alias)
        {
            return this.DbContext.SimNetworks.Where(x => x.Alias == alias);
        }
    }
}