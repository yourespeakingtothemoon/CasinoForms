using CasinoForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Controllers
{
    internal class BlackJackManager
    {
        public PlayerModel GetScore(PlayerModel person)
        {
            bool acedUp = false;
            int total = 0;
            foreach (var card in person.hand)
            {
                total += card.value;
                if (card.value == 1) acedUp = true;
            }
            if (acedUp && total + 10 <= 21)
            {
                total += 10;
            }
            if (total > 21) total = -1;
            person.hand1Value = total;

            if (person.splitHand != null)
            {
                total = 0;
                acedUp = false;
                foreach (var card in person.splitHand)
                {
                    total += card.value;
                    if (card.value == 1) acedUp = true;
                }
                if (acedUp && total + 10 <= 21)
                {
                    total += 10;
                }
                if (total > 21) total = -1;
                person.hand2Value = total;
            }
            return person;
        }

        public bool isBusted(PlayerModel person)
        {
            if (person.hand1Value > 21) return true;
            return false;
        }

        public int whoWon(PlayerModel dealer, PlayerModel player)
        {
            if (dealer.hand1Value > player.hand1Value && dealer.hand1Value > player.hand2Value ||
                dealer.hand2Value > player.hand1Value && dealer.hand2Value > player.hand2Value)
            {
                return 0;
            }

            else if (dealer.hand1Value < player.hand1Value && dealer.hand1Value < player.hand2Value ||
                     dealer.hand2Value < player.hand1Value && dealer.hand2Value < player.hand2Value) 
            {
                if (player.hand.Count >= 5) return 3;
                return 2;
            }

            return 1;

        }

    }
}
