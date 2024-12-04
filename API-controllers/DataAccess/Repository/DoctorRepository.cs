using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class DoctorRepository : Repo<Doctor, int>, IDoctorRepository
{
    private readonly OperationsDepartmentContext context;

    public DoctorRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }

    public async Task<bool> AssignMedicalCase(DoctorsInChargeOfCase entity)
    {
        await context.DoctorsInChargeOfCases.AddAsync(entity);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<bool> AssignOperation(DoctorsInCaseOperation entity)
    {
        await context.DoctorsInCaseOperations.AddAsync(entity);
        return await context.SaveChangesAsync() > 0;
    }

    public async Task<List<Doctor>> GetBestDoctors()
    {
        return await context.Doctors
            .Include(d => d.DoctorsInCaseOperations)
            .OrderByDescending(d => d.DoctorsInCaseOperations.Count)
            .ToListAsync();
    }

    public async Task<List<Doctor?>> GetBusyDostors()
    {
        return await context.DoctorsInCaseOperations
            .Where(o => o.EndOfOperating > DateTime.Now || o.EndOfOperating == null)
            .Select(d => d.Doctor)
            .ToListAsync();
    }
}
