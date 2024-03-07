using CasinoForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasinoForms.Controllers
{
    public class PokerManager
    {
        public int HandType(PlayerModel player)
        {
            //Pair - 1:1
            /*Two Pair -5:1
              Three of a Kind -10:1
              Straight - 25:1
              Flush - 50:1
              Full House -100:1
              Four of a Kind -1,000:1
              Straight Flush -10,000:1
              Royal Flush -100,000:1*/

            int clubs = 0;
            int spades = 0;
            int hearts = 0;
            int diamonds = 0;
            foreach (var card in player.hand)
            {
                switch(card.suit)
                {
                    case "Hearts":
                        hearts++;
                        break;
                    case "Diamonds":
                        diamonds++;
                        break;
                    case "Clubs":
                        clubs++;
                        break;
                    case "Spades":
                        spades++;
                        break;
                    default:
                        break;
                }
            }

            if (clubs == 5 || spades == 5 || hearts == 5 || diamonds == 5) 
            {
                if (straght(player))
                {
                    bool Ace = false;
                    bool c10 = false;
                    foreach (var card in player.hand)
                    {
                        if (card.number == 10) c10 = true;
                        if (card.number == 1) Ace = true;
                    }
                    if (Ace && c10) return 100000;
                    return 10000;
                }
                return 50;
            }

            if (straght(player)) return 25;

            List<CardModel> tempCards = player.hand;
            foreach (var card in tempCards)
            {
                int FoundFriends = 0;
                foreach(var card2 in tempCards) 
                {
                    if (card.value == card2.value) FoundFriends++;
                }
                if (FoundFriends < 2) tempCards.Remove(card);
            }
            if (tempCards.Count == 5) return 100;
            if (tempCards.Count == 3) return 10;
            if (tempCards.Count == 2) return 1;
            if (tempCards.Count == 4) 
            {
                int goldenValue = tempCards.First().value;
                bool TwoPair = false;
                foreach (var card in tempCards)
                {
                    if (card.value != goldenValue) TwoPair = true;
                }
                if(!TwoPair) return 1000;
                return 5;
            }

            return 0;
        }

        public bool straght(PlayerModel player)
        {
            bool Ace = false;
            int highest = 13;
            int lowest = 0;
            foreach (var card in player.hand)
            {
                if (card.number == 1) Ace = true;
                if (card.number < highest) highest = card.number;
                if (card.number > lowest) lowest = card.number;
            }
            if (Ace && highest == 13) 
            { 
                for (int i = 1; i < 4; i++) 
                {
                    bool continues = false;
                    foreach (var card in player.hand)
                    {
                        if (card.number == highest - i) continues = true;
                    }
                    if (!continues) return false;
                }
                return true;
            }
            if (lowest + 4 == highest)
            {
                for (int i = 1; i < 4; i++)
                {
                    bool continues = false;
                    foreach (var card in player.hand)
                    {
                        if (card.number == highest - i) continues = true;
                    }
                    if (!continues) return false;
                }
                return true;
            }

            return false;
        }
    }
}
