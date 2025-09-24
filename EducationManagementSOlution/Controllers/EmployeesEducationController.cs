using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesEducationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EmployeesEducationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeesEducation>> Get()
        {
            try
            {
                return await _unitOfWork.EmployeesEducationRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<EmployeesEducation>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<EmployeesEducation> Get(int id)
        {
            try
            {
                return await _unitOfWork.EmployeesEducationRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new EmployeesEducation();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(EmployeesEducation entity)
        {
            try
            {
                await _unitOfWork.EmployeesEducationRepo.Add(entity);
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
        public async Task<ModelMessage> Put(EmployeesEducation entity)
        {
            try
            {
                _unitOfWork.EmployeesEducationRepo.Update(entity);
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
                await _unitOfWork.EmployeesEducationRepo.DeletebyID(id);
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
