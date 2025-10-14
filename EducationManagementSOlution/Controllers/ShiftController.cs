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
    public class ShiftController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ShiftController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Shift>> Get()
        {
            try
            {
                return await _unitOfWork.ShiftRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Shift>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Shift> Get(int id)
        {
            try
            {
                return await _unitOfWork.ShiftRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Shift();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Shift entity)
        {
            try
            {
                await _unitOfWork.ShiftRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Shift entity)
        {
            try
            {
                _unitOfWork.ShiftRepo.Update(entity);
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
                await _unitOfWork.ShiftRepo.DeletebyID(id);
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
