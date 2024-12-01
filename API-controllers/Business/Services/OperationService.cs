using AutoMapper;
using Business.DTO;
using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using DataAccess.Repository;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services;

public class OperationService : Service<Operation, CreateOperationDTO>, IOperationService
{
    public OperationService(IOperationRepository _repo, IMapper _mapper)
        : base(_mapper, _repo)
    {

    }
}

