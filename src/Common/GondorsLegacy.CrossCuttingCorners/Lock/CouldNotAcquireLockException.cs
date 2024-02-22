using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GondorsLegacy.CrossCuttingCorners.Lock;

public class CouldNotAcquireLockException : Exception
{
    public CouldNotAcquireLockException()
    {
    }

    public CouldNotAcquireLockException(string message)
        : base(message)
    {
    }

    public CouldNotAcquireLockException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}