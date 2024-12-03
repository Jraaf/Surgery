using Business.Exceptions;
using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class OperationRepository : Repo<Operation, int>, IOperationRepository
{
    private readonly OperationsDepartmentContext context;

    public OperationRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }
    public new async Task<List<Operation>> GetAllAsync()
    {
        return await context.Operations.Include(o => o.CaseOperations)
                .ThenInclude(co => co.Case)
                .ToListAsync();
    }
    public new async Task<Operation?> GetAsync(int id)
    {
        return await context.Operations
            .Include(o => o.CaseOperations)
                .ThenInclude(co => co.Case)
            .FirstOrDefaultAsync(o => o.OperationId == id)
                 ?? throw new NotFoundException(id);
    }
}
