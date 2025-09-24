﻿using EducationManagement_DLL.Infrastructures.Base;
using EducationManagement_DLL.Models;
using EducationManagement_DLL.Models.Exam_Models;
using EducationManagement_DLL.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EducationManagementSOlution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstituteController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private ModelMessage message;
        public InstituteController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            message = new ModelMessage();
        }
        [HttpGet]
        public async Task<IEnumerable<Institute>> Get()
        {
            try
            {
                return await _unitOfWork.InstituteRepo.GetAll();
            }
            catch (Exception ex)
            {
                return Enumerable.Empty<Institute>();
            }
        }
        [HttpGet("{id:int}")]
        public async Task<Institute> Get(int id)
        {
            try
            {
                return await _unitOfWork.InstituteRepo.GetById(id);
            }
            catch (Exception ex)
            {
                return new Institute();
            }
        }
        [HttpPost]
        public async Task<ModelMessage> Post(Institute entity)
        {
            try
            {
                await _unitOfWork.InstituteRepo.Add(entity);
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
        public async Task<ModelMessage> Put(Institute entity)
        {
            try
            {
                _unitOfWork.InstituteRepo.Update(entity);
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
                await _unitOfWork.InstituteRepo.DeletebyID(id);
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
