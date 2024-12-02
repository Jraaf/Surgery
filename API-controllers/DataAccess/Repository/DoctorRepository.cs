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

public class DoctorRepository:Repo<Doctor,int>,IDoctorRepository
{
    public DoctorRepository(OperationsDepartmentContext context)
        :base(context)
    {
    }
}
