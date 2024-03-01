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
        PlayerModel GetScore(PlayerModel person)
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
                person.hand2Value = total;
            }
            return person;
        }

    }
}
