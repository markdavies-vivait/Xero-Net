using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xero.Api.Infrastructure.Exceptions
{
    public class ApiExceptionProblemInvalidField
    {
        public string Name { get; set; }
        public string Reason { get; set; }

    }
}
