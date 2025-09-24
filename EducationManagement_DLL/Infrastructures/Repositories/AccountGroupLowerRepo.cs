using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using RoyalAPI.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IAccountGroupLower : IGenericRepository<AccountGroupLower> { }


    public class AccountGroupLowerRepo : GenericRepository<AccountGroupLower>, IAccountGroupLower
    {
        public AccountGroupLowerRepo(SchoolContext context) : base(context) { }
    }
}
