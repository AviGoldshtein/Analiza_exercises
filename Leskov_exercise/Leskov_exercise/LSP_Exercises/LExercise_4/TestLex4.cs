using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_4
{
    internal class TestLex4 : Itest
    {
        public void Run()
        {
            List<IAccount> bankAccounts = new List<IAccount>();

            for (int i = 0; i < 10; i++)
            {
                BankAccount bankAccountP = new BankAccount(200 - i, "private");
                BankAccount bankAccountB = new BankAccount(200 + i, "Business");

                bankAccounts.Add(bankAccountP);
                bankAccounts.Add(bankAccountB);
            }

            Console.WriteLine($"the sum of private accounts: {SumBalancesForType("private", bankAccounts)}");
            Console.WriteLine($"the sum of business accounts: {SumBalancesForType("Business", bankAccounts)}");
        }
        public int SumBalancesForType(string type, List<IAccount> bankAccounts)
        {
            int sum = 0;
            foreach(IAccount account in bankAccounts)
            {
                if (account.GetTypeAccount() == type)
                {
                    sum += account.GetAvailableBalance();
                }
            }
            return sum;
        }
    }
}
