using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Payroll.NewZealand.Model.Status;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace="")]
    public class Timesheet
    {
        [DataMember(Name = "TimesheetID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "EmployeeID")]
        public string EmployeeId { get; set; }

        [DataMember(Name = "PayrollCalendarID")]
        public string PayrollCalendarId { get; set; }

        [DataMember]
        public string StartDate { get; set; }

        [DataMember]
        public string EndDate { get; set; }

        [DataMember]
        public TimesheetStatus Status { get; set; }

        [DataMember]
        public decimal TotalHours { get; set; }

        [DataMember]
        public List<TimesheetLine> TimesheetLines { get; set; }
    }
}
