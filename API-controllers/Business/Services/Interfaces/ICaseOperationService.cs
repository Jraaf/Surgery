using API_controllers.Business.DTO;
using Business.Services.Interfaces;
using DataAccess.Entities;

namespace API_controllers.Business.Services.Interfaces
{
    public interface ICaseOperationService:ICrud<CaseOperation,CreateCaseOperationDTO>
    {
    }
}
