using System.Collections.Generic;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class PayrollCalendarResponse : XeroResponse<PayrollCalendar>
    {
        public IList<PayrollCalendar> PayrollCalendars { get; set; }

        public override IList<PayrollCalendar> Values
        {
            get { return PayrollCalendars; }
        }
    }
}