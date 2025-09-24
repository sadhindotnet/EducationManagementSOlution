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
    public interface IExamRoutine : IGenericRepository<ExamRoutine> { }


    public class ExamRoutineRepo : GenericRepository<ExamRoutine>, IExamRoutine
    {
        public ExamRoutineRepo(SchoolContext context) : base(context) { }
    }
}
