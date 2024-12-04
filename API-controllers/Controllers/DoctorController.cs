using API_controllers.Business.DTO;
using Business.DTO;
using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_controllers.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DoctorController(IDoctorService _service) : ControllerBase
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
    public async Task<IActionResult> Post(CreateDoctorDTO model)
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
    public async Task<IActionResult> Update(int id, CreateDoctorDTO DTO)
    {
        var data = await _service.UpdateByIdAsync(id, DTO);
        return Ok(data);
    }
    [HttpPost("AssignOperation")]
    public async Task<IActionResult> AssignOperation(CreateDoctorsInCaseOperationsDTO dto)
    {
        return await _service.AssignOperation(dto)? Ok():BadRequest();
    }
    [HttpPost("AssignMedicalCase")]
    public async Task<IActionResult> AssignMedicalCase(CreateDoctorsInChargeOfCaseDTO dto)
    {
        return await _service.AssignMedicalCase(dto) ? Ok() : BadRequest();
    }
}
