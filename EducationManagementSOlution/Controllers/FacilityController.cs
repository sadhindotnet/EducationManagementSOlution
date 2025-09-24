using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public FacilityController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Facility>> Get()
        {
            try
            {
                return await _unitOfWork.FacilityRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Facility>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Facility> Get(int id)
        {
            try
            {
                return await _unitOfWork.FacilityRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Facility();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Facility entity)
        {
            try
            {
                await _unitOfWork.FacilityRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Facility entity)
        {
            try
            {
                _unitOfWork.FacilityRepo.Update(entity);
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
                await _unitOfWork.FacilityRepo.DeletebyID(id);
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
