namespace EventExercise
{
    public class OverdraftAccount : BankAccount
    {
        public BankAccount SavingsAccount { get; set; }

        public OverdraftAccount(int initialAmount, int savingsAmount) 
            : base(initialAmount)
        {
            SavingsAccount = new BankAccount(savingsAmount);
        }

        public new void Withdraw(int amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return;
            }

            var outstandingWithdrawalAmount = amount - Balance;
            SavingsAccount.Withdraw(outstandingWithdrawalAmount);
            OnOverdrawn(new BankAccountEventArgs { OriginalBalance = Balance });
            Balance = 0;
        }
    }
}
