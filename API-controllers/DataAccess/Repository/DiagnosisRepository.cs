﻿using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class DiagnosisRepository : Repo<Diagnosis, int>, IDiagnosisRepository
{
    private readonly OperationsDepartmentContext context;

    public DiagnosisRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }

    public async Task<List<Diagnosis>> GetAllWithDetails()
    {
        return await context.Diagnoses.Include(x => x.MedicalCases)
                .ToListAsync();
    }
}
