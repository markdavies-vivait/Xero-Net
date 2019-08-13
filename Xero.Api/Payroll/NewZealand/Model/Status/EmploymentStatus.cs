using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Status
{
    [DataContract(Namespace = "")]
    public enum EmploymentStatus
    {
        [EnumMember(Value = "ACTIVE")]
        Active,
        [EnumMember(Value = "TERMINATED")]
        Terminated
    }
}