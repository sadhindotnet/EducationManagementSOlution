using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.WebsiteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IAdministrativeDepartment : IGenericRepository<AdministrativeDepartment> { }


    public class AdministrativeDepartmentRepo : GenericRepository<AdministrativeDepartment>, IAdministrativeDepartment
    {
        public AdministrativeDepartmentRepo(SchoolContext context) : base(context) { }
    }
}
