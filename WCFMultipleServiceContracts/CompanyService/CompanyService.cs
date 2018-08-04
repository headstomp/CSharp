using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class CompanyService : ICompanyPublicService, ICompanyConfidentialService
    {
        public string GetPublicInformation()
        {
            return "This information is available over HTTP to all general public outside the firewall";
        }

        public string GetConfidentialInformation()
        {
            return "This is confidential information and only available over TCP benhind the company firewall";
        }
    }
}
