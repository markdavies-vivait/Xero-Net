using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.Common.Model;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace = "")]
    public class TimesheetLine : HasUpdatedDate
    {
        [DataMember(Name = "TimesheetLineID")]
        public Guid? TimesheetLineId { get; set; }

        [DataMember(Name = "Date")]
        public string Date { get; set; }

        [DataMember(Name = "EarningsRateID")]
        public Guid EarningsRateId { get; set; }

        [DataMember(Name = "TrackingItemID", EmitDefaultValue = false)]
        public Guid TrackingItemID { get; set; }

        [DataMember]
        public decimal NumberOfUnits { get; set; }
    }
}
