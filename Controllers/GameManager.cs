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

        BlackJackManager blackJackManager = new BlackJackManager();
        PokerManager pokerManager = new PokerManager();

        public int bet;

        public bool downDoubled = false;

        public int payoutAmount;


        List<CardModel> deck = new List<CardModel>();

        public GameManager()
        {
        }

        public void StartBlackJack()
        {
            turnCount = 0;
            SetDeck();

            downDoubled = false;

            player.hand = null;
            player.splitHand = null;
            player.hand1Value = 0;
            player.hand2Value = 0;

            dealer.hand = null;
            dealer.splitHand = null;
            dealer.hand1Value = 0;
            dealer.hand2Value = 0;

            DrawCards(2, player);
            DrawCards(2, dealer);
            checkScore();

        }

        public void checkScore()
        {
            dealer = blackJackManager.GetScore(dealer);
            player = blackJackManager.GetScore(player);
        }

        public void SetBet(int betAmount)
        {
            bet = betAmount;
        }

        public void Payout(int ratio)
        {
            payoutAmount = bet * ratio;

        }

        public void DealerTurn()
        {
            if (turnCount == 1)
            {
                Split(dealer);
            }
            checkScore();
            if (dealer.hand1Value < 17)
            {
                DrawCards(1, dealer);
            }
            if (dealer.hand2Value < 17 && dealer.hand != null)
            {
                DrawCardsForSplit(1, dealer);
            }
        }

        public void playerTurn(string action)
        {
            switch (action)
            {
                case "draw":
                    if (!downDoubled)
                    {
                        DrawCards(1, player);
                        if (player.splitHand != null)
                        {
                            DrawCardsForSplit(1, dealer);
                        }
                    }
                    break;
                case "split":
                    Split(player);
                    break;
                case "DoubleDown":
                    DoubleDown();
                    break;
                case "Stand":
                    break;
            }
            checkScore();
            DealerTurn();
        }

        private void DoubleDown()
        {
            downDoubled = true;
            DrawCards(1, player);
        }

        public void Split(PlayerModel spliter)
        {
            if (turnCount == 0)
            {
                if (spliter.hand.ElementAt(1).number == spliter.hand.ElementAt(0).number)
                {
                    spliter.splitHand = new List<CardModel>
                    {
                        player.hand.ElementAt(1)
                    };
                    spliter.hand.RemoveAt(1);
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

        public void DrawCards(int loops, PlayerModel player)
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
        public void DrawCardsForSplit(int loops, PlayerModel player)
        {
            turnCount++;
            for (int i = 0; i < loops; i++)
            {
                Random random = new Random();
                int cardDrawn = random.Next(deck.Count - 1);
                player.splitHand.Add(deck.ElementAt(cardDrawn));
                deck.RemoveAt(cardDrawn);
            }
        }
    }
}