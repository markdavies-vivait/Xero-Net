using Xero.Api.Infrastructure.Http;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.NewZealand.Request;
using Xero.Api.Payroll.NewZealand.Response;
using Xero.Api.Payroll.Common;

namespace Xero.Api.Payroll.NewZealand.Endpoints
{
    public class LeaveTypesEndpoint  : PayrollEndpoint<LeaveTypesEndpoint, LeaveType, LeaveTypesRequest, LeaveTypesResponse>
    {
        public LeaveTypesEndpoint(XeroHttpClient client)
            : base(client, "payroll.xro/2.0/leaveTypes")
        {
        }
    }
}
