using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Models.IdentityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface ITokenApiModel : IGenericRepository<TokenApiModel> { }


    public class TokenApiModelRepo : GenericRepository<TokenApiModel>, ITokenApiModel
    {
        public TokenApiModelRepo(SchoolContext context) : base(context) { }
    }
}
