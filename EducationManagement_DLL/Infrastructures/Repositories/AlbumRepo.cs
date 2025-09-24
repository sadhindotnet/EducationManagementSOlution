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
    public interface IAlbum : IGenericRepository<Album> { }


    public class AlbumRepo : GenericRepository<Album>, IAlbum
    {
        public AlbumRepo(SchoolContext context) : base(context) { }
    }
}
