namespace Unit_4___OOPb_part_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunExampleTwo();
        }

        static void RunExampleOne()
        {
            //CheckingAccount checkingAccount = new CheckingAccount();
            //checkingAccount.OverDraftFee = 0;
            //checkingAccount._id = 5;

            CheckingAccount checkingAccount = new CheckingAccount("12345", "246810", 25.50M);
            Console.WriteLine(checkingAccount.GetId);

            decimal withdrawlAmount = checkingAccount.Withdrawl(9999.99M);

            BankAccount bankAccount = new BankAccount("12345", "246810");

            Console.WriteLine(bankAccount.Withdrawl(50.00M));

            CheckingAccount myCheckingAccount = new CheckingAccount("333559", "6969420360", -90.00M);
        } 

        static void RunExampleTwo()
        {
            // PolyMorphism -> poly = "Many"   morph = "shape", Polymorphism just states
            // objects can take "many shapes" in the case of OOP, CHILD classes can "take the shape"
            // of their parent classes.
            BankAccount myBankAccount = new CheckingAccount("333559", "6969420360", -90.00M);
            myBankAccount.Withdrawl(50.50M);

            List<BankAccount> bankAccounts = new List<BankAccount>();

            bankAccounts.Add(new BankAccount("5465464", "49684624"));
            bankAccounts.Add(myBankAccount);
            bankAccounts.Add(new SavingsAccount("999548", "4498754", 0.05M));

            foreach (var bankAccount in bankAccounts)
            {
                bankAccount.Withdrawl(50.00M);
            }

            Console.WriteLine(myBankAccount.ToString());
        }
    }
}