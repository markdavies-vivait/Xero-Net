using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model.Status;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace = "")]
    public class Employment : HasUpdatedDate
    {
        [DataMember(EmitDefaultValue = false)]
        public Guid? PayRunCalendarID { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Guid? PayrollCalendarID { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public DateTime? StartDate { get; set; }
    }
}
