namespace Unit_4___OOPb_part_1
{

    public class BankAccount
    {
        public BankAccount(string accountNumber, string routingNumber)
        {
            AccountNumber = accountNumber;
            RoutingNumber = routingNumber;
        }

        // the protected access modifier is just Private WITHEN it's 
        // inheritence chain. so any class that Inherits from BankAccount
        // will have ACCESS to _id. However, it is NOT public, so anything OUTSIDE
        // of the chain, will NOT have access it.
        protected int _id;
        public string AccountNumber { get; set; }
        public string RoutingNumber { get; set; }
        public decimal AccountBalance { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }

        public virtual decimal Withdrawl(decimal withdrawlAmount)
        {
            AccountBalance -= withdrawlAmount;
            return withdrawlAmount;
        }

        public override string ToString()
        {
            return $"Account Number: {AccountNumber}\nRoutingNumber: {RoutingNumber}\nAccountBalance: {AccountBalance}";
        }
    }

    public class CheckingAccount : BankAccount
    {
        // the BASE keyword refers to the BASE inherited class
        public CheckingAccount(string accountNumber, string routingNumber, decimal overDraftFee) 
            : base(accountNumber, routingNumber)
        {
           this.OverDraftFee = overDraftFee;
        }

        public decimal OverDraftFee { get; set; }


        // read only property
        public int GetId => _id;

        // Overriding a method, OVERWRITES the PARENT CLASSES Method, so WHen
        // this. object calls the Overwridden method, it will NOT call the 
        // parent (base) class method.
        public override decimal Withdrawl(decimal withdrawlAmount)
        {
            AccountBalance -= withdrawlAmount;
            if (AccountBalance < 0)
            {
                AccountBalance -= this.OverDraftFee;
            }
            return withdrawlAmount;
        }

        // Method Overlading
        public decimal Withdrawl()
        {
            return this.Withdrawl(60.00M);
        }

    }

    public class HighCashCheckingsAccount : CheckingAccount
    {
        public HighCashCheckingsAccount(string accountNumber, string routingNumber, decimal overDraftFee) : base(accountNumber, routingNumber, overDraftFee)
        {
        }
    }

    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string accountNumber, string routingNumber, decimal interestRate) 
            : base(accountNumber, routingNumber)
        {
            this.InterestRate = interestRate;
        }

        public decimal InterestRate { get; set; }

        public override decimal Withdrawl(decimal withdrawlAmount)
        {
            decimal totalWithdrawn = base.Withdrawl(withdrawlAmount);

            this.AccountBalance *= this.InterestRate;
            this.ToString();

            return totalWithdrawn;
        }
    }
}
