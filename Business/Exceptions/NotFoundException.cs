using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Exceptions;

public class NotFoundException : Exception
{
    public NotFoundException()
        : base()
    {

    }
    public NotFoundException(string message)
        : base(message)
    {

    }
    public NotFoundException(int id)
        : base($"There is nothing found by id {id}")
    {

    }
}
