using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Status
{
    [DataContract(Namespace = "")]
    public enum TimesheetStatus
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "COMPLETE")]
        Complete,
        [EnumMember(Value = "APPROVED")]
        Approved
    }
}