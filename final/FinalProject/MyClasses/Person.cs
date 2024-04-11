using System.Text;

namespace FinalProject.MyClasses
{
	public class Person : ContactInformation
	{
		private string _firstName;
		private string _lastName;
		private string _idCard;

		public Person(string nit, string rif, string idCard, string firstName, string lastName, string email, string[] phones, string webPage, string address)
			: base(nit, rif, email, phones, webPage, address)
		{
			_idCard = idCard;
			_firstName = firstName;
			_lastName = lastName;
		}

		public override string GetIdInfo()
		{
			StringBuilder idInfo = new StringBuilder();
			idInfo.AppendLine("===================================================");
			idInfo.AppendLine($"|            Identification Information            |");
			idInfo.AppendLine("===================================================");
			idInfo.AppendLine($"|   ID: {_idCard}                                   |");
			idInfo.AppendLine("===================================================");

			return idInfo.ToString();
		}

		public override string GetName()
		{
			return _lastName + ", " + _firstName;
		}

		public override string GetContactInfo()
		{
			StringBuilder contactInfo = new StringBuilder();
			contactInfo.AppendLine("===================================================");
			contactInfo.AppendLine($"|               Contact Information                 |");
			contactInfo.AppendLine("===================================================");
			contactInfo.AppendLine($"|   Name: {_firstName} {_lastName}                   |");
			contactInfo.AppendLine($"|   Email: {_email}                                 |");
			foreach (string phone in _phones)
			{
				contactInfo.AppendLine($"|   Phone: {phone}                              |");
			}
			contactInfo.AppendLine($"|   Website: Not applicable                          |");
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
			detailedInfo.AppendLine($"|            Detailed Information of the Person    |");
			detailedInfo.AppendLine("===================================================");
			detailedInfo.AppendLine($"|   Name: {_firstName} {_lastName}                   |");
			detailedInfo.AppendLine($"|   ID Card: {_idCard}                               |");
			detailedInfo.AppendLine($"|   Email: {_email}                                 |");
			foreach (string phone in _phones)
			{
				detailedInfo.AppendLine($"|   Phone: {phone}                              |");
			}
			detailedInfo.AppendLine($"|   Address: {_address}                             |");
			detailedInfo.AppendLine($"|   Website: Not applicable                          |");
			detailedInfo.AppendLine("===================================================");

			return detailedInfo.ToString();
		}

	}
}
