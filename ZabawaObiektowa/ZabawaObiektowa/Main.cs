using System;

namespace ZabawaObiektowa
{	
	class BankAccount
	{
		public BankAccount (decimal amount, string _owner)
		{
			balance=amount;
			owner=_owner;
		}
		public void withdrawal (decimal amount)
		{
			balance-=amount;
		}
		public void deposit (decimal amount)
		{
			balance+=amount;
		}
		public decimal getBalance ()
		{
			return balance;
		}
		public string getOwner ()
		{
			return owner;
		}

		private decimal balance;
		private string	owner;
	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			BankAccount account=new BankAccount(1000, "Dupa");
			account.withdrawal(100);
			Console.WriteLine(account.getBalance());
			Console.WriteLine (account.getOwner ());
		}
	}
}