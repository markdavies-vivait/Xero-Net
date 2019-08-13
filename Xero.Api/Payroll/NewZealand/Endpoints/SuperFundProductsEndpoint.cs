using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.NewZealand.Response;

namespace Xero.Api.Payroll.NewZealand.Endpoints
{
    [DataContract(Namespace = "")]
    public class SuperFundProductsEndpoint : XeroReadEndpoint<SuperFundProductsEndpoint, SuperFundProduct, SuperFundProductsResponse>
    {
        public SuperFundProductsEndpoint(XeroHttpClient client)
            : base(client, "payroll.xro/2.0/SuperFundProducts")
        {
        }
    }
}