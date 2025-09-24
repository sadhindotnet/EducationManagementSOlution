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
    public interface IStdPayment : IGenericRepository<StdPayment> { }


    public class StdPaymentRepo : GenericRepository<StdPayment>, IStdPayment
    {
        public StdPaymentRepo(SchoolContext context) : base(context) { }
    }
}
