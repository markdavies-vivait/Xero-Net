using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class TimesheetLinesResponse : XeroResponse<TimesheetLine>
    {
        public IList<TimesheetLine> TimesheetLines { get; set; }
        public TimesheetLine TimesheetLine { get; set; }

        public override IList<TimesheetLine> Values
        {
            get { return TimesheetLine == null ? TimesheetLines : new List<TimesheetLine> { TimesheetLine }; }
        }
    }
}
