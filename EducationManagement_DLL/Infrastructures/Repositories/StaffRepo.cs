using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IStaff : IGenericRepository<Staff> { }


    public class StaffRepo : GenericRepository<Staff>, IStaff
    {
        public StaffRepo(SchoolContext context) : base(context) { }
    }
}
