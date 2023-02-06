using AAI.DataContract.Models.Login;
using AAI.DataContract.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAI.RepositoryContract.Login
{
    public interface ILoginInterface
    {
        Task<DataContract.Models.Login.UserDetailViewModel> GetLoginDetailsAsync(string email, string password);     
    }
}
