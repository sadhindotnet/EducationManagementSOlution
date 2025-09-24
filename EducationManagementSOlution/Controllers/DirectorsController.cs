using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public DirectorsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Directors>> Get()
        {
            try
            {
                return await _unitOfWork.DirectorsRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Directors>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Directors> Get(int id)
        {
            try
            {
                return await _unitOfWork.DirectorsRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Directors();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Directors entity)
        {
            try
            {
                await _unitOfWork.DirectorsRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Directors entity)
        {
            try
            {
                _unitOfWork.DirectorsRepo.Update(entity);
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
                await _unitOfWork.DirectorsRepo.DeletebyID(id);
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
