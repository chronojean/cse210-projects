namespace FinalProject.MyClasses
{
    public class Income : Transaction
    {
        public Income(string transactionID, DateTime date, string description, decimal amount, ContactInformation entity) : base(transactionID, date, description, amount, entity)
        {
        }

        public override decimal GetAmount()
        {
            return _amount;
        }
    }
}
