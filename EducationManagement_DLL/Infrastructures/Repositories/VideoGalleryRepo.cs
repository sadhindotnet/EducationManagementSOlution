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
    public interface IVideoGallery : IGenericRepository<VideoGallery> { }


    public class VideoGalleryRepo : GenericRepository<VideoGallery>, IVideoGallery
    {
        public VideoGalleryRepo(SchoolContext context) : base(context) { }
    }
}
