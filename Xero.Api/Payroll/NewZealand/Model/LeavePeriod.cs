using System;
using System.Runtime.Serialization;
using Xero.Api.Payroll.NewZealand.Model.Status;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace = "")]
    public class LeavePeriod
    {
        [DataMember]
        public string PeriodStartDate { get; set; }

        [DataMember]
        public string PeriodEndDate { get; set; }

        [DataMember]
        public LeavePeriodStatus PeriodStatus { get; set; }

        [DataMember]
        public decimal NumberOfUnits { get; set; }
    }
}
