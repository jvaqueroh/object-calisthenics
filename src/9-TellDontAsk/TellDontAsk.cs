using System;

public class BankAccount {
    public decimal Balance { get; set; }
    public decimal CreditLimit { get; set; }
    
    public BankAccount(decimal balance, decimal creditLimit)
    {
        Balance = balance;
        CreditLimit = creditLimit;
    }
}

public class Program {
    public void main() {
        var myAccount = new BankAccount(1000M, 500M);

        var moneyToWithdraw = 300M;
        if (myAccount.Balance < moneyToWithdraw || myAccount.CreditLimit < moneyToWithdraw)
            throw new InvalidOperationException();
        myAccount.Balance -= moneyToWithdraw;
    }
}