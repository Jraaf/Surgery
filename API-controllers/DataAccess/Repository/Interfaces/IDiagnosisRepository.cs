using DataAccess.Entities;
using DataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces;

public interface IDiagnosisRepository:IRepo<Diagnosis,int>
{
    Task<List<Diagnosis>> GetAllWithDetails();
}
