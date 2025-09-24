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
    public class EmployeesJobHistroyController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EmployeesJobHistroyController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeesJobHistroy>> Get()
        {
            try
            {
                return await _unitOfWork.EmployeesJobHistroyRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<EmployeesJobHistroy>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<EmployeesJobHistroy> Get(int id)
        {
            try
            {
                return await _unitOfWork.EmployeesJobHistroyRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new EmployeesJobHistroy();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(EmployeesJobHistroy entity)
        {
            try
            {
                await _unitOfWork.EmployeesJobHistroyRepo.Add(entity);
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
        public async Task<ModelMessage> Put(EmployeesJobHistroy entity)
        {
            try
            {
                _unitOfWork.EmployeesJobHistroyRepo.Update(entity);
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
                await _unitOfWork.EmployeesJobHistroyRepo.DeletebyID(id);
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
