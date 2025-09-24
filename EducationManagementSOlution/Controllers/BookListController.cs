using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models.WebsiteModels;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookListController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public BookListController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<BookList>> Get()
        {
            try
            {
                return await _unitOfWork.BookListRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<BookList>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<BookList> Get(int id)
        {
            try
            {
                return await _unitOfWork.BookListRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new BookList();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(BookList entity)
        {
            try
            {
                await _unitOfWork.BookListRepo.Add(entity);
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
        public async Task<ModelMessage> Put(BookList entity)
        {
            try
            {
                _unitOfWork.BookListRepo.Update(entity);
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
                await _unitOfWork.BookListRepo.DeletebyID(id);
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
