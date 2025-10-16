using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EmployeeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Employee>> Get()
        {
            try
            {
                return await _unitOfWork.EmployeeRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Employee>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Employee> Get(int id)
        {
            try
            {
                return await _unitOfWork.EmployeeRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Employee();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Employee entity)
        {
            try
            {
                await _unitOfWork.EmployeeRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Employee entity)
        {
            try
            {
                _unitOfWork.EmployeeRepo.Update(entity);
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
                await _unitOfWork.EmployeeRepo.DeletebyID(id);
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
