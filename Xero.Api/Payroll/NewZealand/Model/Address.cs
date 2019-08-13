using System.Runtime.Serialization;
using Xero.Api.Payroll.NewZealand.Model.Types;

namespace Xero.Api.Payroll.NewZealand.Model
{
    [DataContract(Namespace = "")]
    public class Address
    {
        [DataMember]
        public string AddressLine1 { get; set; }

        [DataMember]
        public string AddressLine2 { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Suburb{ get; set; }

        [DataMember]
        public string CountryName { get; set; }

        [DataMember]
        public int PostCode { get; set; }

    }
}