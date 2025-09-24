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
    public interface IInstituteChartAcct : IGenericRepository<InstituteChartAcct> { }


    public class InstituteChartAcctRepo : GenericRepository<InstituteChartAcct>, IInstituteChartAcct
    {
        public InstituteChartAcctRepo(SchoolContext context) : base(context) { }
    }
}
