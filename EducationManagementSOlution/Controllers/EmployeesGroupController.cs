using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesGroupController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public EmployeesGroupController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<EmployeesGroup>> Get()
        {
            try
            {
                return await _unitOfWork.EmployeesGroupRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<EmployeesGroup>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<EmployeesGroup> Get(int id)
        {
            try
            {
                return await _unitOfWork.EmployeesGroupRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new ();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(EmployeesGroup entity)
        {
            try
            {
                await _unitOfWork.EmployeesGroupRepo.Add(entity);
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
        public async Task<ModelMessage> Put(EmployeesGroup entity)
        {
            try
            {
                _unitOfWork.EmployeesGroupRepo.Update(entity);
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
                await _unitOfWork.EmployeesGroupRepo.DeletebyID(id);
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

