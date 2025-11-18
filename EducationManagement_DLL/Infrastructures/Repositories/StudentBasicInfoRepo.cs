using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IStudentBasicInfo : IGenericRepository<StudentBasicInfo> {
        public bool isExist(string name, string fatherContact);
        public Task<string> GetImage(string uerName);
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
        public async Task<string> GetImage(string uerName)
        {
            var std= await _context.StudentBasicInfos.FirstOrDefaultAsync(s => s.UserName == uerName);
            return std.StudentPicturePath ?? "";
        }
    }
}
