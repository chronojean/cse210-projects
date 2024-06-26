namespace FinalProject.MyClasses
{
	public abstract class Transaction
	{
		protected string _transactionID;

		protected DateTime _date;
		protected string _description;
		protected decimal _amount;
		protected ContactInformation _entity;

		public Transaction(string transactionID, DateTime date, string description, decimal amount, ContactInformation entity)
		{
			_transactionID = transactionID;
			_date = date;
			_description = description;
			_amount = amount;
			_entity = entity;
		}

		public abstract decimal GetAmount();

		public ContactInformation GetMadeBy()
		{
			return _entity;
		}
		public DateTime GetDate()
		{
			return _date;
		}
		public string GetDescription()
		{
			return _description;
		}
	}
}

