namespace CustomerControlSystem
{
    class CorporateCustomer : Customer
    {
        public string CNPJ { get; set; }
        public string StateRegistration { get; set; }

        public override void PayTax(float value)
        {
            PurchaseValue = value;
            TaxValue = PurchaseValue * 20 / 100;
            TotalValue = PurchaseValue + TaxValue;
        }
    }
}
