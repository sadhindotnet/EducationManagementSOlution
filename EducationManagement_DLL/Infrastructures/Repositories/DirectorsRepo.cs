using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.WebsiteModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IDirectors : IGenericRepository<Directors> { }


    public class DirectorsRepo : GenericRepository<Directors>, IDirectors
    {
        public DirectorsRepo(SchoolContext context) : base(context) { }
    }
}
