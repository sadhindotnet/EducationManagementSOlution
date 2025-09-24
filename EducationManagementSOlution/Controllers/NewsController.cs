using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoyalAPI.Models.AccountModels;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public NewsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<News>> Get()
        {
            try
            {
                return await _unitOfWork.NewsRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<News>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<News> Get(int id)
        {
            try
            {
                return await _unitOfWork.NewsRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new News();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(News entity)
        {
            try
            {
                await _unitOfWork.NewsRepo.Add(entity);
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
        public async Task<ModelMessage> Put(News entity)
        {
            try
            {
                _unitOfWork.NewsRepo.Update(entity);
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
                await _unitOfWork.NewsRepo.DeletebyID(id);
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
