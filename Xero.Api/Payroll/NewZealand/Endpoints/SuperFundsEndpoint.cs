using System.Runtime.Serialization;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.NewZealand.Request;
using Xero.Api.Payroll.NewZealand.Response;
using Xero.Api.Payroll.Common;

namespace Xero.Api.Payroll.NewZealand.Endpoints
{
    [DataContract(Namespace = "")]
    public class SuperFundsEndpoint : PayrollEndpoint<SuperFundsEndpoint, SuperFund, SuperFundsRequest, SuperFundsResponse>
    {
        public SuperFundsEndpoint(XeroHttpClient client)
            : base(client, "payroll.xro/2.0/SuperFunds")
        {
        }
    }
}