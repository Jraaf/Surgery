using API_controllers.Business.DTO;
using Business.DTO;
using DataAccess.Entities;

namespace Business.Services.Interfaces;

public interface IDoctorService: ICrud<Doctor,CreateDoctorDTO>
{
    Task<bool> AssignMedicalCase(CreateDoctorsInChargeOfCaseDTO dto);
    Task<bool> AssignOperation(CreateDoctorsInCaseOperationsDTO dto);
}
