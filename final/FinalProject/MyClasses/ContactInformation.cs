namespace FinalProject.MyClasses
{
	public abstract class ContactInformation
	{
		protected string _nit;
		protected string _rif;

		protected string _email;
		protected string[] _phones;
		protected string _webPage;

		protected string _address;

		public ContactInformation(string nit, string rif, string email, string[] phones, string webPage, string address)
		{
			_nit = nit;
			_rif = rif;
			_email = email;
			_phones = phones;
			_webPage = webPage;
			_address = address;
		}

		public abstract string GetIdInfo();
		public abstract string GetName();
		public abstract string GetContactInfo();
		public abstract string GetAddress();
		public abstract string GetDetailedInfo();
	}
}