using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class SuperFundsResponse : XeroResponse<SuperFund>
    {
        public IList<SuperFund> SuperFunds { get; set; }

        public override IList<SuperFund> Values
        {
            get { return SuperFunds; }
        }
    }
}