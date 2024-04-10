namespace FinalProject.MyClasses
{
    public class Income : Transaction
    {
        public Income(DateTime date, string description, decimal amount, ContactInformation entity) : base(date, description, amount, entity)
        {
        }

        // Implementación del método abstracto para ingresos
        public override decimal GetAmount()
        {
            return _amount;
        }
    }
}