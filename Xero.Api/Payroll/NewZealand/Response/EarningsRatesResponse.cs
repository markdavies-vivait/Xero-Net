using System.Collections.Generic;
using System.Runtime.Serialization;
using Xero.Api.Common;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class EarningsRatesResponse: XeroResponse<EarningsRate>
    {
        public IList<EarningsRate> EarningsRates{ get; set; }

        public override IList<EarningsRate> Values
        {
            get { return EarningsRates; }
        }
    }
}