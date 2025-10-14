using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftwiseClassController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ShiftwiseClassController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<ShiftwiseClass>> Get()
        {
            try
            {
                return await _unitOfWork.ShiftwiseClassRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<ShiftwiseClass>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<ShiftwiseClass> Get(int id)
        {
            try
            {
                return await _unitOfWork.ShiftwiseClassRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new ShiftwiseClass();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(ShiftwiseClass entity)
        {
            try
            {
                await _unitOfWork.ShiftwiseClassRepo.Add(entity);
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
        public async Task<ModelMessage> Put(ShiftwiseClass entity)
        {
            try
            {
                _unitOfWork.ShiftwiseClassRepo.Update(entity);
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
                await _unitOfWork.ShiftwiseClassRepo.DeletebyID(id);
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
