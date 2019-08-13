﻿using System;
using System.Runtime.Serialization;
using Xero.Api.Common;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace = "")]
    public class LeaveType : HasUpdatedDate
    {
        [DataMember(Name = "LeaveTypeID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public bool IsPaidLeave { get; set; }

        [DataMember]
        public bool ShowOnPayslip { get; set; }
    }
}