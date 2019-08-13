using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Types
{
    [DataContract(Namespace = "")]
    public enum RateType
    {
        [EnumMember(Value = "Fixed")]
        Fixed,
        [EnumMember(Value = "MultipleOfOrdinaryEarningsRate")]
        MultipleOfOrdinaryEarningsRate,
        [EnumMember(Value = "RatePerUnit")]
        RatePerUnit,
    }
}