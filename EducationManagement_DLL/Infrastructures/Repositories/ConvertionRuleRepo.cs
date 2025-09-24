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
    public interface IConvertionRule : IGenericRepository<ConvertionRule>
    {

    }
    public class ConvertionRuleRepo : GenericRepository<ConvertionRule>, IConvertionRule
    {
        public ConvertionRuleRepo(SchoolContext context) : base(context) { }
    }
}
