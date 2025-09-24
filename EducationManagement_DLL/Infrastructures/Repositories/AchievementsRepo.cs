using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Models.WebsiteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IAchievements : IGenericRepository<Achievements> { }


    public class AchievementsRepo : GenericRepository<Achievements>, IAchievements
    {
        public AchievementsRepo(SchoolContext context) : base(context) { }
    }
}
