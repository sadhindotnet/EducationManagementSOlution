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
    public interface IClassSubjectInst : IGenericRepository<ClassSubjectInst> { }


    public class ClassSubjectInstRepo : GenericRepository<ClassSubjectInst>, IClassSubjectInst
    {
        public ClassSubjectInstRepo(SchoolContext context) : base(context) { }
    }
}
