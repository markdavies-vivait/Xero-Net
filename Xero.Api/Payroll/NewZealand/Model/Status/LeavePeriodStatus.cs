using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Status
{
    [DataContract(Namespace =  "")]
    public enum LeavePeriodStatus
    {
        [EnumMember(Value = "COMPLETED")]
        Completed,
        [EnumMember(Value = "APPROVED")]
        Approved
    }
}