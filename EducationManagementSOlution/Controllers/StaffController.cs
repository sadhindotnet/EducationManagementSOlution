using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public StaffController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Staff>> Get()
        {
            try
            {
                return await _unitOfWork.StaffRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Staff>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Staff> Get(int id)
        {
            try
            {
                return await _unitOfWork.StaffRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Staff();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Staff entity)
        {
            try
            {
                await _unitOfWork.StaffRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Staff entity)
        {
            try
            {
                _unitOfWork.StaffRepo.Update(entity);
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
                await _unitOfWork.StaffRepo.DeletebyID(id);
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
