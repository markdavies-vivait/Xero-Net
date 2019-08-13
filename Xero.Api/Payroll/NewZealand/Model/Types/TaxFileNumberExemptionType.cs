using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Types
{
    [DataContract(Namespace = "", Name = "TFNExemptionType")]
    public enum TaxFileNumberExemptionType
    {
        [EnumMember(Value = "NOTQUOTED")]
        NotQuoted,
        [EnumMember(Value = "PENDING")]
        Pending,
        [EnumMember(Value = "PENSIONER")]
        Pensioner,
        [EnumMember(Value = "UNDER18")]
        Under18
    }
}