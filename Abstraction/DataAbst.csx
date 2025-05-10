public class BankAccount
{
   private double _balance;

   public BankAccount(double initialAmount)
   {
       _balance = initialAmount;
   }


   public double ShowBalance()
   {
       return _balance;
   }

   public void Deposit(double amount) 
   {
       if (amount > 0)
       {
           _balance += amount;
       }
   }

   public void Withdraw(double amount)
   {
       if (amount > 0 && amount <= _balance)
        {
           _balance -= amount;
        }
   }
}


