using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassSubjectInstController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ClassSubjectInstController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ClassSubjectInst>> Get()
        {
            try
            {
                return await _unitOfWork.ClassSubjectInstRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ClassSubjectInst>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ClassSubjectInst> Get(int id)
        {
            try
            {
                return await _unitOfWork.ClassSubjectInstRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new ClassSubjectInst();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(ClassSubjectInst entity)
        {
            try
            {
                await _unitOfWork.ClassSubjectInstRepo.Add(entity);
                message = _unitOfWork.Save();

            }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
        [HttpPut]
        public async Task<ModelMessage> Put(ClassSubjectInst entity)
        {
            try
            {
                _unitOfWork.ClassSubjectInstRepo.Update(entity);
                message = _unitOfWork.Save();

            }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
        [HttpDelete]
        public async Task<ModelMessage> Delete(int id)
        {
            try
            {
                await _unitOfWork.AlbumRepo.DeletebyID(id);
                message = _unitOfWork.Save();

            }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
    }
}
