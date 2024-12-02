using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class PatientRepository : Repo<Patient, int>, IPatientRepository
{
    private readonly OperationsDepartmentContext context;

    public PatientRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }
    public async new Task<List<Patient>> GetAllAsync()
    {
        return await context.Patients.Include(i => i.MedicalCases).ToListAsync();
    }

    public async new Task<Patient?> GetAsync(int id)
    {
        return await context.Patients
            .Include(i => i.MedicalCases)
            .FirstOrDefaultAsync(i => i.PatientId == id);
    }
}
