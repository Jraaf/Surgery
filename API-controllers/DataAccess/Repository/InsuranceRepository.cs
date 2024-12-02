using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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
