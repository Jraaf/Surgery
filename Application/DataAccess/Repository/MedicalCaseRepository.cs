using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository;

public class MedicalCaseRepository:Repo<MedicalCase,int>,IMedicalCaseRepository
{
    public MedicalCaseRepository(OperationsDepartmentContext context)
        :base(context)
    {
        
    }
}
