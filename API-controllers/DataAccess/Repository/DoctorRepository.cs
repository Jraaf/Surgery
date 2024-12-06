using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System.Linq.Expressions;

namespace DataAccess.Repository;

public class DoctorRepository : Repo<Doctor, int>, IDoctorRepository
{
    private readonly OperationsDepartmentContext context;

    public DoctorRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Doctor>> GetAllAsync()
    {
        return await context.Doctors
            .Include(d => d.DoctorsInChargeOfCases)
                .ThenInclude(dcc => dcc.Case)
            .Include(d => d.DoctorsInCaseOperations)
                .ThenInclude(dco => dco.CaseOperation)
            .ToListAsync();
    }
    public async new Task<Doctor?> GetAsync(int id)
    {
        return await context.Doctors
            .Include(d => d.DoctorsInChargeOfCases)
                .ThenInclude(dcc => dcc.Case)
            .Include(d => d.DoctorsInCaseOperations)
                .ThenInclude(dco => dco.CaseOperation)
            .FirstOrDefaultAsync(d=>d.DoctorId == id);
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
            .Include(d => d.DoctorsInChargeOfCases)
                .ThenInclude(dcc => dcc.Case)
            .Include(d => d.DoctorsInCaseOperations)
                .ThenInclude(dco => dco.CaseOperation)
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
