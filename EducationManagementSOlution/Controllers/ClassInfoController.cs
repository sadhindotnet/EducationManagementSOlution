using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassInfoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public ClassInfoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet ]
        public async Task<IEnumerable<AcademyClass>> Get()
        {
            try
            {
                return await  _unitOfWork.AcademyClassRepo.GetAll();
            }
            catch(Exception ex)
            {
                return Enumerable.Empty<AcademyClass>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<AcademyClass> Get(int id)
        {
            try
            {
                return await _unitOfWork.AcademyClassRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new  AcademyClass   ();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(AcademyClass entity)
        {
            try
            {
                await _unitOfWork.AcademyClassRepo.Add(entity);
                message = _unitOfWork.Save();
               
            }
            catch(Exception ex)
            {
                message.IsSuccess = false;
                message.Message = ex.Message;
            }
            return message;
        }
        [HttpPut]
        public async Task<ModelMessage> Put(AcademyClass entity)
        {
            try
            {
                 _unitOfWork.AcademyClassRepo.Update(entity);
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
               await  _unitOfWork.AcademyClassRepo.DeletebyID(id);
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
