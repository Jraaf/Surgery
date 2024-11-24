using DataAccess.Entities;
using DataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces;

public interface IMedicalCaseRepository : IRepo<MedicalCase, int>
{
}
