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
    public interface IAttendance : IGenericRepository<Attendance> { }


    public class AttendanceRepo : GenericRepository<Attendance>, IAttendance
    {
        public AttendanceRepo(SchoolContext context) : base(context) { }
    }
}
