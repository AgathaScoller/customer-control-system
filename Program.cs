using System;

namespace CustomerControlSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            float purchaseValue;

            Console.WriteLine("Enter customer name:");
            string customerName = Console.ReadLine();

            Console.WriteLine("Enter customer address:");
            string customerAddress = Console.ReadLine();

            Console.WriteLine("Is the customer an Individual (i) or Corporate (c)?");
            string customerType = Console.ReadLine().ToLower();

            if (customerType == "i")
            {
                IndividualCustomer customer = new IndividualCustomer();

                customer.Name = customerName;
                customer.Address = customerAddress;

                Console.WriteLine("Enter CPF:");
                customer.CPF = Console.ReadLine();

                Console.WriteLine("Enter RG:");
                customer.RG = Console.ReadLine();

                Console.WriteLine("Enter purchase value:");
                purchaseValue = float.Parse(Console.ReadLine());

                customer.PayTax(purchaseValue);

                Console.WriteLine();
                Console.WriteLine("========== INDIVIDUAL CUSTOMER ==========");
                Console.WriteLine($"Name...............: {customer.Name}");
                Console.WriteLine($"Address............: {customer.Address}");
                Console.WriteLine($"CPF................: {customer.CPF}");
                Console.WriteLine($"RG.................: {customer.RG}");
                Console.WriteLine($"Purchase Value.....: {customer.PurchaseValue:C}");
                Console.WriteLine($"Tax................: {customer.TaxValue:C}");
                Console.WriteLine($"Total Amount.......: {customer.TotalValue:C}");
            }
            else if (customerType == "c")
            {
                CorporateCustomer customer = new CorporateCustomer();

                customer.Name = customerName;
                customer.Address = customerAddress;

                Console.WriteLine("Enter CNPJ:");
                customer.CNPJ = Console.ReadLine();

                Console.WriteLine("Enter State Registration:");
                customer.StateRegistration = Console.ReadLine();

                Console.WriteLine("Enter purchase value:");
                purchaseValue = float.Parse(Console.ReadLine());

                customer.PayTax(purchaseValue);

                Console.WriteLine();
                Console.WriteLine("========== CORPORATE CUSTOMER ==========");
                Console.WriteLine($"Name...............: {customer.Name}");
                Console.WriteLine($"Address............: {customer.Address}");
                Console.WriteLine($"CNPJ...............: {customer.CNPJ}");
                Console.WriteLine($"State Registration.: {customer.StateRegistration}");
                Console.WriteLine($"Purchase Value.....: {customer.PurchaseValue:C}");
                Console.WriteLine($"Tax................: {customer.TaxValue:C}");
                Console.WriteLine($"Total Amount.......: {customer.TotalValue:C}");
            }
            else
            {
                Console.WriteLine("Invalid customer type.");
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
