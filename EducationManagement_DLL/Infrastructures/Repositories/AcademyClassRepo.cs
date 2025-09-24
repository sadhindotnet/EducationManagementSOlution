
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
    public interface IAcademyClass : IGenericRepository<AcademyClass> {

        List<AcademyClass> GetbyPrg(int prgid);
    }


    public class AcademyClassRepo : GenericRepository<AcademyClass>, IAcademyClass
    {
        private readonly SchoolContext  _contex;
        public AcademyClassRepo(SchoolContext context) : base(context) {
            _contex = context;
        }

        public List<AcademyClass> GetbyPrg(int prgid)
        {
            return _contex.AcademyClasses.Where(c => c.PrgId == prgid).ToList();
        }
    }
    
}
