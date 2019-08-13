using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Status
{
    [DataContract(Namespace = "")]
    public enum ResidencyStatus
    {
        [EnumMember(Value = "AUSTRALIANRESIDENT")]
        AustralianResident,
        [EnumMember(Value = "FOREIGNRESIDENT")]
        ForeignResident,
        [EnumMember(Value = "WORKINGHOLIDAYMAKER")]
        WorkingHoliday,
    }
}