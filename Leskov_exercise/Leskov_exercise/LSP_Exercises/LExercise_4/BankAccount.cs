using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leskov_exercise.Exercise_4
{
    internal class BankAccount : IAccount
    {
        int Balance = 0;
        private string Type;
        public BankAccount(int balance, string type)
        {
            Balance = balance;
            Type = type;
        }
        public int GetAvailableBalance() => Balance;
        public string GetTypeAccount() => Type;
    }
}
