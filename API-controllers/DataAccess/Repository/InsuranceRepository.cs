using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class InsuranceRepository : Repo<Insurance, int>, IInsuranceRepository
{
    private readonly OperationsDepartmentContext context;

    public InsuranceRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Insurance>> GetAllAsync()
    {
        return await context.Insurances.Include(i => i.MedicalCases).ToListAsync();
    }

    public async new Task<Insurance?> GetAsync(int id)
    {
        return await context.Insurances
            .Include(i => i.MedicalCases)
            .FirstOrDefaultAsync(i => i.InsuranceId == id);
    }
}
