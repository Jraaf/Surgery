using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;

namespace DataAccess.Repository;

public class PatientRepository:Repo<Patient,int>,IPatientRepository
{
    public PatientRepository(OperationsDepartmentContext context)
        :base(context)
    {
        
    }
}
