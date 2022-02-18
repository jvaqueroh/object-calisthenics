using System;

public class BankAccount {
    private decimal balance;
    private decimal creditLimit;
    
    public BankAccount(decimal balance, decimal creditLimit)
    {
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

public class Program {
    public void main() {
        var myAccount = new BankAccount(1000M, 500M);
        var moneyToWithdraw = 300M;
        myAccount.WithdrawMoney(moneyToWithdraw);
        Console.WriteLine(myAccount.ToString());
    }
}