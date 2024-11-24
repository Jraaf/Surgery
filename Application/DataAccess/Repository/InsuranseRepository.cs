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

public class InsuranseRepository:Repo<Insurance,int>,IInsuranceRepository
{
    public InsuranseRepository(OperationsDepartmentContext context)
        :base(context)
    {
        
    }
}
