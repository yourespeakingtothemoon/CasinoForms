using CasinoForms.Models;
using CasinoForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Controllers
{
    public class ApplicationManager
    {
        List<Form> screens = new List<Form>();
        BankModel bank;
       public UserModel user;

        public TitleScreen titleScreen;
        public ApplicationManager()
        {
            bank = new BankModel();
            user = new UserModel();
        }

        public ApplicationManager(UserModel user)
        {
            bank = new BankModel();
            this.user = user;
        }

        public ApplicationManager(UserModel user, float bankAmount)
        {
            this.bank = new BankModel(bankAmount);
            this.user = user;
        }

        public void AddScreen(Form screen)
        {
            screens.Add(screen);
        }
        public void RemoveScreen(Form screen)
        {
            screens.Remove(screen);
        }

        public void GoToScreen(int screen)
        {
            screens[screen].Show();
        }
        public void CloseScreen(int screen)
        {
            screens[screen].Close();
        }


        //payout for games
        public void Payout(PlayerModel player)
        {
           if(player.money!=null) user.balance += (float)player.money;

        }


    }
}
