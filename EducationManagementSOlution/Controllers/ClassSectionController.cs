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
    public class ClassSectionController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ClassSectionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ClassSection>> Get()
        {
            try
            {
                return await _unitOfWork.ClassSectionRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ClassSection>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ClassSection> Get(int id)
        {
            try
            {
                return await _unitOfWork.ClassSectionRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new ClassSection();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(ClassSection entity)
        {
            try
            {
                await _unitOfWork.ClassSectionRepo.Add(entity);
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
        public async Task<ModelMessage> Put(ClassSection entity)
        {
            try
            {
                _unitOfWork.ClassSectionRepo.Update(entity);
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
                await _unitOfWork.ClassSectionRepo.DeletebyID(id);
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
