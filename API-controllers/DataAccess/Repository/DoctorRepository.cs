using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
}
