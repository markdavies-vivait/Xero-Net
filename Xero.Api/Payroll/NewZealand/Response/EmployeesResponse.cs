using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class EmployeesResponse : XeroResponse<Employee>
    {
        public IList<Employee> Employee { get; set; }
        public IList<Employee> Employees { get; set; }

        public override IList<Employee> Values
        {
            get { return Employee ?? Employees; }
        }
    }
}