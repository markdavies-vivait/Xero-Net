using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class TimesheetsResponse : XeroResponse<Timesheet>
    {
        public IList<Timesheet> Timesheets { get; set; }
        public Timesheet Timesheet { get; set; }

        public override IList<Timesheet> Values
        {
            get { return Timesheet == null ? Timesheets : new List<Timesheet> { Timesheet }; }
        }
    }
}
