using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace = "")]
    public class EmployeeLeave : HasUpdatedDate
    {
        [DataMember(Name = "LeaveApplicationID", EmitDefaultValue = false)]
        public Guid? Id { get; set; }

        [DataMember(Name = "LeaveTypeID", EmitDefaultValue = false)]
        public Guid LeaveTypeId { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Description { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string StartDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string EndDate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<LeavePeriod> LeavePeriods { get; set; }
    }
}
