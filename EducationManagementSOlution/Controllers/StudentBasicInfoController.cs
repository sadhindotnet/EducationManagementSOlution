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
    public class StudentBasicInfoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public StudentBasicInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<StudentBasicInfo>> Get()
        {
            try
            {
                return await _unitOfWork.StudentBasicInfoRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<StudentBasicInfo>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<StudentBasicInfo> Get(int id)
        {
            try
            {
                return await _unitOfWork.StudentBasicInfoRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new StudentBasicInfo();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(StudentBasicInfo entity)
        {
            try
            {
                await _unitOfWork.StudentBasicInfoRepo.Add(entity);
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
        public async Task<ModelMessage> Put(StudentBasicInfo entity)
        {
            try
            {
                _unitOfWork.StudentBasicInfoRepo.Update(entity);
                message = _unitOfWork.Save();

            }
            catch (Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
        [HttpDelete("{id}")]
        public async Task<ModelMessage> Delete(int id)
        {
            try
            {
                await _unitOfWork.StudentBasicInfoRepo.DeletebyID(id);
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
