using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using RoyalAPI.Models.AccountModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IClassRoutine : IGenericRepository<ClassRoutine> { }


    public class ClassRoutineRepo : GenericRepository<ClassRoutine>, IClassRoutine
    {
        public ClassRoutineRepo(SchoolContext context) : base(context) { }
    }
}
