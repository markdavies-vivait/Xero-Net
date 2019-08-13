using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class EmployeeLeaveResponse : XeroResponse<EmployeeLeave>
    {
        public IList<EmployeeLeave> Leave { get; set; }

        public override IList<EmployeeLeave> Values
        {
            get { return Leave; }
        }
    }
}