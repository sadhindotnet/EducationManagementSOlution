using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeQualificationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EmployeeQualificationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeeQualification>> Get()
        {
            try
            {
                return await _unitOfWork.EmployeeQualificationRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<EmployeeQualification>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<EmployeeQualification> Get(int id)
        {
            try
            {
                return await _unitOfWork.EmployeeQualificationRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new EmployeeQualification();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(EmployeeQualification entity)
        {
            try
            {
                await _unitOfWork.EmployeeQualificationRepo.Add(entity);
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
        public async Task<ModelMessage> Put(EmployeeQualification entity)
        {
            try
            {
                _unitOfWork.EmployeeQualificationRepo.Update(entity);
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
                await _unitOfWork.EmployeeQualificationRepo.DeletebyID(id);
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
