using Business.DTO;
using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using DataAccess.Repository.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class DiagnosisController(IDiagnosisService _service) : ControllerBase
    {
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var data = await _service.GetAllAsync();
                if (data != null)
                {
                    return Ok(data);
                }
            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
            return NoContent();
        }
        [HttpGet("GetById")]

        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                var data = await _service.GetAsync(id);
                if (data != null)
                {
                    return Ok(data);
                }
            }
            catch (NotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception)
            {
                throw;
            }

            return NoContent();
        }
        [HttpPost("add")]
        public async Task<IActionResult> Post(CreateDiagnosisDTO model)
        {
            var data = await _service.AddAsync(model);
            return Ok(data);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return Ok();
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update(int id, CreateDiagnosisDTO DTO)
        {
            var data = await _service.UpdateByIdAsync(id, DTO);
            return Ok(data);
        }
    }
}
