using System.Collections.Generic;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Infrastructure.Exceptions
{
    public class ApiExceptionProblem
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }
        public string Detail { get; set; }
        public string Instance { get; set; }
        public List<ApiExceptionProblemInvalidField> InvalidFields { get; set; }

    }

}

