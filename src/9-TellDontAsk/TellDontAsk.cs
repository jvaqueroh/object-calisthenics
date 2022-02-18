    using System;

    public class BankAccount {
        private decimal balance;
        private decimal creditLimit;
        
        public BankAccount(decimal balance, decimal creditLimit) {
            this.balance = balance;
            this.creditLimit = creditLimit;
        }
        
        public void WithdrawMoney(decimal moneyToWithdraw) {
            if (balance < moneyToWithdraw || creditLimit < moneyToWithdraw)
                throw new InvalidOperationException();
            balance -= moneyToWithdraw;
        }

        public override string ToString() {
            return $"Balance: {balance}, Credit limit: {creditLimit}";
        }
    }

    public static class Program {
        public static void Main(string[] args) {
            var myAccount = new BankAccount(1000M, 500M);
            myAccount.WithdrawMoney(300M);
            Console.WriteLine(myAccount);
        }
    }