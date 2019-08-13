using System.Runtime.Serialization;

namespace Xero.Api.Payroll.NewZealand.Model.Types
{
    [DataContract(Namespace = "")]
    public enum LeaveCalculationType
    {
        [EnumMember(Value = "FIXEDAMOUNTEACHPERIOD")]
        FixedAmountEachPeriod,
        [EnumMember(Value = "ENTERRATEINPAYTEMPLATE")]
        EnterRateInPayTemplate,
        [EnumMember(Value = "BASEDONORDINARYEARNINGS")]
        BasedOnOrdinaryEarnings
    }
}