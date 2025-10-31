using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IStudentBasicInfo : IGenericRepository<StudentBasicInfo> {
        public bool isExist(string name, string fatherContact);
    }


    public class StudentBasicInfoRepo : GenericRepository<StudentBasicInfo>, IStudentBasicInfo
    {
        SchoolContext _context;
        public StudentBasicInfoRepo(SchoolContext context) : base(context) {
            this._context = context;
        }
        public bool isExist(string name, string fatherContact)
        {
            return
                   _context.StudentBasicInfos.Any(s => s.StudentName.ToLower().Equals(name) && s.StudentFathersContract.Equals(fatherContact));
        }
    }
}
