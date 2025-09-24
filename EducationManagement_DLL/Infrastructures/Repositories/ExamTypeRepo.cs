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
    public interface IExamType : IGenericRepository<ExamType> { }


    public class ExamTypeRepo : GenericRepository<ExamType>, IExamType
    {
        public ExamTypeRepo(SchoolContext context) : base(context) { }
    }

}
