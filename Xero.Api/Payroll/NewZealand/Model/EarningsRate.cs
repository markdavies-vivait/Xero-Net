using System;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model.Types;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace = "")]
    public class EarningsRate : HasUpdatedDate
    {
        [DataMember(Name = "EarningsRateID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public EarningsType EarningsType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public RateType RateType { get; set; }

        [DataMember]
        public string TypeOfUnits { get; set; }

        [DataMember]
        public string ExpenseAccountID { get; set; }

        [DataMember]
        public bool CurrentRecord { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? RatePerUnit { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? MultipleOfOrdinaryEarningsRate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal? FixedAmount { get; set; }
    }
}