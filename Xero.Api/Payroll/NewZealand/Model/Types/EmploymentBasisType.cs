using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Types
{
    [DataContract(Namespace = "")]
    public enum EmploymentBasisType
    {
        [EnumMember(Value = "FULLTIME")]
        FullTime,
        [EnumMember(Value = "PARTTIME")]
        PartTime,
        [EnumMember(Value = "CASUAL")]
        Casual,
        [EnumMember(Value = "LABOURHIRE")]
        LabouRHire,
        [EnumMember(Value = "SUPERINCOMESTREAM")]
        SuperIncomeStream
    }
}