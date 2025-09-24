using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.AccountsModel;
using RoyalAPI.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IAccountGroupTop : IGenericRepository<AccountGroupTop> { }


    public class AccountGroupTopRepo : GenericRepository<AccountGroupTop>, IAccountGroupTop
    {
        public AccountGroupTopRepo(SchoolContext context) : base(context) { }
    }
}
