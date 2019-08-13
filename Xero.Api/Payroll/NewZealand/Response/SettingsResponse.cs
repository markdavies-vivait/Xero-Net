using System.Collections.Generic;
using Xero.Api.Infrastructure.Interfaces;
using Xero.Api.Payroll.NewZealand.Model;

namespace Xero.Api.Payroll.NewZealand.Response
{
    public class SettingsResponse : IXeroResponse<Settings>
    {
        public Settings Settings { get; private set; }
        
        public IList<Settings> Values { get { return new[] { Settings }; } }
    }
}
