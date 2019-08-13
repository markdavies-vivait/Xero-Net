using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Request
{
    [CollectionDataContract(Namespace = "", Name = "PayrollCalendars")]
    public class PayrollCalendarsRequest : XeroRequest<PayrollCalendar>
    {
    }
}