using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.Exam_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IGrade : IGenericRepository<Grade> { }


    public class GradeRepo : GenericRepository<Grade>, IGrade
    {
        public GradeRepo(SchoolContext context) : base(context) { }
    }
}
