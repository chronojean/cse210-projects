namespace FinalProject.MyClasses
{
	public abstract class Transaction
	{
		protected DateTime _date;
		protected string _description;
		protected decimal _amount;
		protected ContactInformation _entity; // Nuevo atributo para representar quién realizó la transacción

		public Transaction(DateTime date, string description, decimal amount, ContactInformation entity)
		{
			_date = date;
			_description = description;
			_amount = amount;
			_entity = entity; // Se asigna la persona o compañía que realizó la transacción
		}

		// Método abstracto para obtener el monto
		public abstract decimal GetAmount();

		// Método para obtener quién realizó la transacción
		public ContactInformation GetMadeBy()
		{
			return _entity;
		}
	}
}

