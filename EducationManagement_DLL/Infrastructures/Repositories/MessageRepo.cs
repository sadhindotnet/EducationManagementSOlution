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
    public interface IMessage : IGenericRepository<Message> { }


    public class MessageRepo : GenericRepository<Message>, IMessage
    {
        public MessageRepo(SchoolContext context) : base(context) { }
    }
}
