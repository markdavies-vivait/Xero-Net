using System.Collections.Generic;
using Xero.Api.Infrastructure.Model;

namespace Xero.Api.Infrastructure.Exceptions
{
    public class ApiExceptionv2
    {
        public string id { get; set; }
        public string ProviderName { get; set; }
        public string DateTimeUTC { get; set; }
        public string HttpStatusCode{ get; set; }
        public ApiExceptionProblem Problem{ get; set; }

    }
}