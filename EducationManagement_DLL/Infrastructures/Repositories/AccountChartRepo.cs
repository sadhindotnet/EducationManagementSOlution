using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.Exam_Models;
using RoyalAPI.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IAccountChart : IGenericRepository<AccountChart> { }


    public class AccountChartRepo : GenericRepository<AccountChart>, IAccountChart
    {
        public AccountChartRepo(SchoolContext context) : base(context) { }
    }
}
