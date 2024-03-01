using CasinoForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CasinoForms.Controllers
{
    internal class GameManager
    {
        public int turnCount = 0;

        PlayerModel player { get; set; } = new PlayerModel();
        PlayerModel dealer { get; set; } = new PlayerModel();

        public int bet;

        public int payoutAmount;


        List<CardModel> deck = new List<CardModel>();

        public GameManager()
        {
        }

        public void StartBlackJack()
        {
            turnCount = 0;
            SetDeck();
            player.hand = null;
            DrawCards(2);

        }

        public void SetBet(int betAmount)
        {
            bet = betAmount;
        }

        public void Payout(int ratio)
        {
            payoutAmount = bet * ratio;

        }

        public void Split()
        {
            if (turnCount == 0)
            {
                if (player.hand.ElementAt(1).number == player.hand.ElementAt(0).number)
                {
                    player.splitHand.Add(player.hand.ElementAt(1));
                    player.hand.RemoveAt(1);
                }
            }

        }

        public void SetDeck()
        {

            int i = 1;
            for (; i < 13; i++)
            {
                CardModel card = new CardModel("Hearts", i % 13);
                deck.Add(card);
            }
            for (; i < 26; i++)
            {
                CardModel card = new CardModel("Hearts", i % 13);
                deck.Add(card);

            }
            for (; i < 39; i++)
            {
                CardModel card = new CardModel("Hearts", i % 13);
                deck.Add(card);

            }
            for (; i < 52; i++)
            {
                CardModel card = new CardModel("Hearts", i % 13);
                deck.Add(card);

            }

            foreach (var card in deck)
            {
                if (card.number > 10)
                {
                    card.value = 10;
                }
                else
                {
                    card.value = card.number;
                }
            }
        }

        public void DrawCards(int loops)
        {
            turnCount++;
            for (int i = 0; i < loops; i++)
            {
                Random random = new Random();
                int cardDrawn = random.Next(deck.Count - 1);
                player.hand.Add(deck.ElementAt(cardDrawn));
                deck.RemoveAt(cardDrawn);
            }
        }
    }
}