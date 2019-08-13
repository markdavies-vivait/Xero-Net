using Xero.Api.Infrastructure.Http;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.NewZealand.Request;
using Xero.Api.Payroll.NewZealand.Response;
using Xero.Api.Payroll.Common;
using System;

namespace Xero.Api.Payroll.NewZealand.Endpoints
{
    public class EmployeeLeaveEndpoint
        : PayrollEndpoint<EmployeeLeaveEndpoint, EmployeeLeave, EmployeeLeaveRequest, EmployeeLeaveResponse>
    {
        public EmployeeLeaveEndpoint(XeroHttpClient client, Guid employeeID)
            : base(client, "payroll.xro/2.0/employees/" +employeeID.ToString() +"/leave")
        {
        }
    }
}