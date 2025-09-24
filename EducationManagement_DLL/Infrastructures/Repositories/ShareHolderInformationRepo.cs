using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.AccountsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IShareHolderInformation : IGenericRepository<ShareHolderInformation> { }


    public class ShareHolderInformationRepo : GenericRepository<ShareHolderInformation>, IShareHolderInformation
    {
        public ShareHolderInformationRepo(SchoolContext context) : base(context) { }
    }
}
