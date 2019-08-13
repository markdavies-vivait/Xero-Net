using Xero.Api.Infrastructure.Http;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.NewZealand.Request;
using Xero.Api.Payroll.NewZealand.Response;
using Xero.Api.Payroll.Common;

namespace Xero.Api.Payroll.NewZealand.Endpoints
{
    public class PayrollCalendarsEndpoint :
        PayrollEndpoint<PayrollCalendarsEndpoint, PayrollCalendar, PayrollCalendarsRequest, PayrollCalendarResponse>
    {
        public PayrollCalendarsEndpoint(XeroHttpClient client)
            : base(client, "payroll.xro/2.0/PayrollCalendars")
        {
        }
    }
}