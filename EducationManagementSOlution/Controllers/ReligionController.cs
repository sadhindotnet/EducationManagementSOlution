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
    public class ReligionController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ReligionController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Religion>> Get()
        {
            try
            {
                return await _unitOfWork.ReligionRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Religion>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Religion> Get(int id)
        {
            try
            {
                return await _unitOfWork.ReligionRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Religion();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Religion entity)
        {
            try
            {
                await _unitOfWork.ReligionRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Religion entity)
        {
            try
            {
                _unitOfWork.ReligionRepo.Update(entity);
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
                await _unitOfWork.ReligionRepo.DeletebyID(id);
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
