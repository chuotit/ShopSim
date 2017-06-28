using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopSim.Data.Infrastructure;
using ShopSim.Model.Models;

namespace ShopSim.Data.Repositories
{
    public interface IFirstNumberRepository : IRepository<FirstNumber>
    {

    }
    public class FirstNumberRepository : RepositoryBase<FirstNumber>, IFirstNumberRepository
    {
        public FirstNumberRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
