using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RIS
{
    public enum EncryptionResult
    {
        NOT_PROCESSED = 0,
        SUCCESS = 1,
        FAILURE_ACCESS_DENIED = 10,
        FAILURE_OTHER = 11
    }
}
