using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeWithGroupController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EmployeeWithGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeeWithGroup>> Get()
        {
            try
            {
                return await _unitOfWork.EmployeeWithGroupRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<EmployeeWithGroup>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<EmployeeWithGroup> Get(int id)
        {
            try
            {
                return await _unitOfWork.EmployeeWithGroupRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new EmployeeWithGroup();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(EmployeeWithGroup entity)
        {
            try
            {
                await _unitOfWork.EmployeeWithGroupRepo.Add(entity);
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
        public async Task<ModelMessage> Put(EmployeeWithGroup entity)
        {
            try
            {
                _unitOfWork.EmployeeWithGroupRepo.Update(entity);
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
                await _unitOfWork.AttendanceRepo.DeletebyID(id);
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
