using AAI.DataContract.Models.Entity.DB;
using AAI.ServiceContract.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.Service.Common
{
    public class CommonService : ICommonService
    {
        private readonly EntityDbContext _dbcontext;

        public CommonService(EntityDbContext dbcontext)
        {
            _dbcontext = dbcontext;

        }

        public async Task<IEnumerable<Measures>> GetPublicActListAsync()
        {
            return await _dbcontext.Public_Acts.Where;
        }
    }
}
