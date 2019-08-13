using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Types
{
    [DataContract(Namespace = "")]
    public enum EarningsType
    {
        [EnumMember(Value = "RegularEarnings")]
        RegularEarnings,
        [EnumMember(Value = "OtherGrossEarnings")]
        OtherGrossEarnings,
        [EnumMember(Value = "WithholdingIncome")]
        WithholdingIncome,
        [EnumMember(Value = "DiscretionaryPayments")]
        DiscretionaryPayments,
    }
}
