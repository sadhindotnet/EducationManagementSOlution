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
    public interface IClassSection : IGenericRepository<ClassSection> { }


    public class ClassSectionRepo : GenericRepository<ClassSection>, IClassSection
    {
        public ClassSectionRepo(SchoolContext context) : base(context) { }
    }
}
