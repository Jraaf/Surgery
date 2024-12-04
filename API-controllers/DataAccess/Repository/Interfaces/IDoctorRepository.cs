using DataAccess.Entities;
using DataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces;

public interface IDoctorRepository : IRepo<Doctor, int>
{
    Task<bool> AssignMedicalCase(DoctorsInChargeOfCase entity);
    Task<bool> AssignOperation(DoctorsInCaseOperation entity);
    Task<List<Doctor?>> GetBusyDostors();
    Task<List<Doctor?>> GetBestDoctors();
}
