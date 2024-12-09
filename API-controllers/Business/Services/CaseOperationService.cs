using API_controllers.Business.DTO;
using API_controllers.Business.Services.Interfaces;
using API_controllers.DataAccess.Repository.Interfaces;
using AutoMapper;
using Business.Services;
using DataAccess.Entities;

namespace API_controllers.Business.Services;

public class CaseOperationService : Service<CaseOperation, CreateCaseOperationDTO>, ICaseOperationService
{
    public CaseOperationService(IMapper mapper, ICaseOperationReposirtory repo)
        : base(mapper, repo)
    {

    }
}
