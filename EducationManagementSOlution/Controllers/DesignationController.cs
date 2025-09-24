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
    public class DesignationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public DesignationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Designation>> Get()
        {
            try
            {
                return await _unitOfWork.DesignationRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Designation>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Designation> Get(int id)
        {
            try
            {
                return await _unitOfWork.DesignationRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Designation();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Designation entity)
        {
            try
            {
                await _unitOfWork.DesignationRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Designation entity)
        {
            try
            {
                _unitOfWork.DesignationRepo.Update(entity);
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
                await _unitOfWork.DesignationRepo.DeletebyID(id);
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
