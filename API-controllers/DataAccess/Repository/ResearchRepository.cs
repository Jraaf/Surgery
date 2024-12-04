using Business.Exceptions;
using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class ResearchRepository : Repo<Research, int>, IResearchRepository
{
    private readonly OperationsDepartmentContext context;

    public ResearchRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }
    public new async Task<List<Research>> GetAllAsync()
    {
        return await context.Researches
            .Include(r => r.ResearchesInCases)
                .ThenInclude(ric => ric.Case)
            .ToListAsync();
    }
    public new async Task<Research?> GetAsync(int id)
    {
        return await context.Researches
                .Include(r => r.ResearchesInCases)
                    .ThenInclude(ric => ric.Case)
                .FirstOrDefaultAsync(r => r.ResearchId == id)
                ?? throw new NotFoundException(id);
    }
}
