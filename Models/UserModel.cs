using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Models
{
    internal class UserModel
    {
        public int id;
        public string? name;
        public float balance;
        private BankModel bank;
        public UserModel(string name, float balance)
        {
            this.name = name;
            this.balance = balance;
            bank = new BankModel(balance);
        }
        public UserModel(int id, string? name, float balance, BankModel bank)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.bank = bank;
        }

        public UserModel()
        {
            bank = new BankModel();
        }

        public void Deposit(float amount)
        {
            bank.inMoney(amount);
            balance -= amount;
        }
    }
}
