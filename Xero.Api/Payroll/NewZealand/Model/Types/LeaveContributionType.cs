using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Types
{
    [DataContract(Namespace = "")]
    public enum LeaveContributionType
    {
        [EnumMember(Value = "SGC")]
        SuperannuationGuaranteeCharge,
        [EnumMember(Value = "SALARYSACRIFICE")]
        SalarySacrifice,
        [EnumMember(Value = "EMPLOYERADDITIONAL")]
        EmployerAdditional,
        [EnumMember(Value = "EMPLOYEE")]
        Employee
    }
}