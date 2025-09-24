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
    public interface IExamwithSubject : IGenericRepository<ExamwithSubject> { }


    public class ExamwithSubjectRepo : GenericRepository<ExamwithSubject>, IExamwithSubject
    {
        public ExamwithSubjectRepo(SchoolContext context) : base(context) { }
    }
}
