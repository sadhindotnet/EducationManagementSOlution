using EducationManagement_DLL.Context;
using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.AccountsModel;
using EducationManagement_DLL.Models.Exam_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationManagement_DLL.Infrastructures.Repositories
{
    public interface IVoucherType : IGenericRepository<VoucherType> { }


    public class VoucherTypeRepo : GenericRepository<VoucherType>, IVoucherType
    {
        public VoucherTypeRepo(SchoolContext context) : base(context) { }
    }
}
