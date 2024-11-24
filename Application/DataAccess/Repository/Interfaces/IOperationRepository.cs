using DataAccess.Entities;
using DataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces;

internal interface IOperationRepository : IRepo<Operation, int>
{
}
