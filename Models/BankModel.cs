using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Models
{
    internal class BankModel
    {
        public int id;

        public float balance;

        public BankModel(float balance)
        {
            this.balance = balance;
        }
        public BankModel()
        {
        }
        
        public void Withdraw(UserModel user, float amount)
        {
            user.balance+=amount;
            balance-=amount;
        }

        public void inMoney(float amount)
        {
            balance += amount;
        }

    }
}
