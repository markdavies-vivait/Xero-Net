using Xero.Api.Infrastructure.Http;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.NewZealand.Request;
using Xero.Api.Payroll.NewZealand.Response;
using Xero.Api.Payroll.Common;
using System;

namespace Xero.Api.Payroll.NewZealand.Endpoints
{
    public class TimesheetLinesEndpoint : PayrollEndpoint<TimesheetLinesEndpoint, TimesheetLine, TimesheetLinesRequest, TimesheetLinesResponse>
    {
        public TimesheetLinesEndpoint(XeroHttpClient client, Guid timesheetID)
            : base(client, "payroll.xro/2.0/Timesheets/" + timesheetID.ToString() + "/lines")
        {
        }
    }
}
