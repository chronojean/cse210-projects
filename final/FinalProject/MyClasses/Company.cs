using System.Text;

namespace FinalProject.MyClasses
{
	public class Company : ContactInformation
	{
		private string _businessName;
		private string _tradeName;

		public Company(string nit, string rif, string businessName, string tradeName, string email, string[] phones, string webPage, string address)
			: base(nit, rif, email, phones, webPage, address)
		{
			_businessName = businessName;
			_tradeName = tradeName;
		}

		public string GetLetterhead()
		{
			StringBuilder letterhead = new StringBuilder();
			letterhead.AppendLine("===================================================");
			letterhead.AppendLine($"|                                                  |");
			letterhead.AppendLine($"|          {_businessName} - {_tradeName}        |");
			letterhead.AppendLine($"|                                                  |");
			letterhead.AppendLine($"|           Address: {_address}               |");
			letterhead.AppendLine($"|           Phone: {_phones[0]}                   |");
			letterhead.AppendLine($"|           Email: {_email}           |");
			letterhead.AppendLine($"|           Website: {_webPage}               |");
			letterhead.AppendLine($"|                                                  |");
			letterhead.AppendLine("===================================================");

			return letterhead.ToString();
		}


		public override string GetIdInfo()
		{
			StringBuilder idInfo = new StringBuilder();
			idInfo.AppendLine("===================================================");
			idInfo.AppendLine($"|          Identification Information             |");
			idInfo.AppendLine("===================================================");
			idInfo.AppendLine($"|   Business Name: {_businessName}               |");
			idInfo.AppendLine($"|   Trade Name: {_tradeName}                     |");
			idInfo.AppendLine($"|   Tax Identification Number (TIN): {_rif}      |");
			idInfo.AppendLine($"|   National Taxpayer Identification Number (NIT): {_nit}  |");
			idInfo.AppendLine("===================================================");

			return idInfo.ToString();
		}


		public override string GetName()
		{
			return _tradeName;
		}

		public override string GetContactInfo()
		{
			StringBuilder contactInfo = new StringBuilder();
			contactInfo.AppendLine("===================================================");
			contactInfo.AppendLine($"|               Contact Information                |");
			contactInfo.AppendLine("===================================================");
			contactInfo.AppendLine($"|   Trade Name: {_tradeName}                       |");
			contactInfo.AppendLine($"|   Email: {_email}                                 |");
			foreach (string phone in _phones)
			{
				contactInfo.AppendLine($"|   Phone: {phone}                              |");
			}
			contactInfo.AppendLine($"|   Website: {_webPage}                             |");
			contactInfo.AppendLine("===================================================");

			return contactInfo.ToString();
		}


		public override string GetAddress()
		{
			StringBuilder addressInfo = new StringBuilder();
			addressInfo.AppendLine("===================================================");
			addressInfo.AppendLine($"|                Address                           |");
			addressInfo.AppendLine("===================================================");
			addressInfo.AppendLine($"|   {_address}                                      |");
			addressInfo.AppendLine("===================================================");

			return addressInfo.ToString();
		}


		public override string GetDetailedInfo()
		{
			StringBuilder detailedInfo = new StringBuilder();
			detailedInfo.AppendLine("===================================================");
			detailedInfo.AppendLine($"|           Detailed Information of the Company     |");
			detailedInfo.AppendLine("===================================================");
			detailedInfo.AppendLine($"|   Trade Name: {_tradeName}                        |");
			detailedInfo.AppendLine($"|   Business Name: {_businessName}                  |");
			detailedInfo.AppendLine($"|   Tax Identification Number (RIF): {_rif}         |");
			detailedInfo.AppendLine($"|   National Taxpayer Identification Number (NIT): {_nit} |");
			detailedInfo.AppendLine($"|   Email: {_email}                                 |");
			foreach (string phone in _phones)
			{
				detailedInfo.AppendLine($"|   Phone: {phone}                              |");
			}
			detailedInfo.AppendLine($"|   Address: {_address}                             |");
			detailedInfo.AppendLine($"|   Website: {_webPage}                             |");
			detailedInfo.AppendLine("===================================================");

			return detailedInfo.ToString();
		}

	}
}
