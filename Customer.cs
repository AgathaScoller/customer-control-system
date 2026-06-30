namespace CustomerControlSystem
{
    class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public float PurchaseValue { get; protected set; }
        public float TaxValue { get; protected set; }
        public float TotalValue { get; protected set; }

        public virtual void PayTax(float value)
        {
            PurchaseValue = value;
            TaxValue = PurchaseValue * 10 / 100;
            TotalValue = PurchaseValue + TaxValue;
        }
    }
}
