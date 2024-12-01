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

public class MedicalCaseRepository : Repo<MedicalCase, int>, IMedicalCaseRepository
{
    private readonly OperationsDepartmentContext _context;
    public MedicalCaseRepository(OperationsDepartmentContext context)
        : base(context)
    {
        _context = context;
    }

    public async Task<List<MedicalCase>> GetMyMedicalCases(int doctorId)
    {
        var medicalCases = await _context.DoctorsInChargeOfCases
            .Where(dic => dic.DoctorId == doctorId) // Filter by DoctorId
            .Select(dic => dic.Case!) // Select the related MedicalCase
            .Include(mc => mc.Patient) // Include the related Patient entity
            .Include(mc=>mc.Diagnose)
            .ToListAsync();

        return medicalCases;
    }
}
