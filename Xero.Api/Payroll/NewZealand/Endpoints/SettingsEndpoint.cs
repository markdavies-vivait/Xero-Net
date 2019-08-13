using Xero.Api.Common;
using Xero.Api.Infrastructure.Http;
using Xero.Api.Payroll.NewZealand.Model;
using Xero.Api.Payroll.NewZealand.Response;

namespace Xero.Api.Payroll.NewZealand.Endpoints
{
    public class SettingsEndpoint : XeroReadEndpoint<SettingsEndpoint, Settings, SettingsResponse>
    {
        public SettingsEndpoint(XeroHttpClient client)
            : base(client, "payroll.xro/2.0/Settings")
        {
        }
    }
}