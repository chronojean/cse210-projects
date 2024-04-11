namespace FinalProject.MyClasses
{
    public class Expense : Transaction
    {
        public Expense(string transactionID, DateTime date, string description, decimal amount, ContactInformation entity) : base(transactionID, date, description, amount * -1, entity)
        {
        }

        // Implementación del método abstracto para gastos
        public override decimal GetAmount()
        {
            return _amount;
        }
    }
}
