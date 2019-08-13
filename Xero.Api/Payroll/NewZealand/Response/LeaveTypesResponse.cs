using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class LeaveTypesResponse: XeroResponse<LeaveType>
    {
        public IList<LeaveType> LeaveTypes { get; set; }
        public IList<LeaveType> LeaveType { get; set; }

        public override IList<LeaveType> Values
        {
            get { return LeaveType ?? LeaveTypes; }
        }
    }
}