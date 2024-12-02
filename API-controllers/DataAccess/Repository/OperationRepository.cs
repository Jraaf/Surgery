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

public class OperationRepository : Repo<Operation, int>, IOperationRepository
{
    private readonly OperationsDepartmentContext context;

    public OperationRepository(OperationsDepartmentContext context)
        : base(context)
    {
        this.context = context;
    }
}
