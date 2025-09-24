using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RulesRegulationController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public RulesRegulationController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<RulesRegulation>> Get()
        {
            try
            {
                return await _unitOfWork.RulesRegulationRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<RulesRegulation>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<RulesRegulation> Get(int id)
        {
            try
            {
                return await _unitOfWork.RulesRegulationRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new RulesRegulation();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(RulesRegulation entity)
        {
            try
            {
                await _unitOfWork.RulesRegulationRepo.Add(entity);
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
        public async Task<ModelMessage> Put(RulesRegulation entity)
        {
            try
            {
                _unitOfWork.RulesRegulationRepo.Update(entity);
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
                await _unitOfWork.RulesRegulationRepo.DeletebyID(id);
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
