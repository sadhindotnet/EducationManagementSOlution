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
    public interface IEmployeesJobHistroy : IGenericRepository<EmployeesJobHistroy> { }


    public class EmployeesJobHistroyRepo : GenericRepository<EmployeesJobHistroy>, IEmployeesJobHistroy
    {
        public EmployeesJobHistroyRepo(SchoolContext context) : base(context) { }
    }
}
