using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IEmployeeWithGroup : IGenericRepository<EmployeeWithGroup> { }


    public class EmployeeWithGroupRepo : GenericRepository<EmployeeWithGroup>, IEmployeeWithGroup
    {
        public EmployeeWithGroupRepo(SchoolContext context) : base(context) { }
    }
}
