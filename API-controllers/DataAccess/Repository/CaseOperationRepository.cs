using API_controllers.DataAccess.Repository.Interfaces;
using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Runtime.CompilerServices;

namespace API_controllers.DataAccess.Repository;

public class CaseOperationRepository : Repo<CaseOperation, int>, ICaseOperationReposirtory
{
    private readonly OperationsDepartmentContext context;

    public CaseOperationRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<CaseOperation>> GetAllAsync()
    {
        return await context.CaseOperations
            .Include(co => co.DoctorsInCaseOperations)
                .ThenInclude(dco => dco.Doctor)
                .ToListAsync();
    }
    public async new Task<CaseOperation> GetById(int id)
    {
        return await context.CaseOperations
            .Include(co => co.DoctorsInCaseOperations)
                .ThenInclude(dco => dco.Doctor)
                .FirstOrDefaultAsync(co=>co.CaseOperationId == id);
    }
}
