using CasinoForms.Models;
using CasinoForms.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CasinoForms.Controllers
{
    public class GameManager
    {
        public int turnCount = 0;

        public PlayerModel player { get; set; } = new PlayerModel();
        public PlayerModel dealer { get; set; } = new PlayerModel();

        public BlackJackManager blackJackManager = new BlackJackManager();
        public PokerManager pokerManager = new PokerManager();

        public Blackjack BlackJackView;

        public int bet =0;

        public bool downDoubled = false;

        public int payoutAmount =0;

        public bool roundEnded = false;
        List<CardModel> deck = new List<CardModel>();

        public GameManager()
        {
        }
        public GameManager(PlayerModel player, Blackjack view)
        {
            this.player = player;
            this.BlackJackView = view;
        }

        public void StartBlackJack()
        {
            turnCount = 0;
            SetDeck();

            downDoubled = false;

            player.hand = new List<CardModel>();
            player.splitHand = null;
            player.hand1Value = 0;
            player.hand2Value = 0;

            dealer.hand = new List<CardModel>();
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
                BlackJackView.revealDealer = false;
            }
            if (dealer.hand2Value < 17 && dealer.hand != null)
            {
                DrawCardsForSplit(1, dealer);
            }
            if(dealer.hand1Value >16)
            {
                BlackJackView.revealDealer = true;
                checkWin();
            }
            if(blackJackManager.isBusted(dealer))
            {
                payoutAmount = bet * 2;
                roundEnded = true;
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
                case "Surrender":
                    player.money -= bet / 2;
                   break;
            }
            checkScore();
            BlackJackView.revealDealerCard();
            if(blackJackManager.isBusted(player))
            {
                bet = 0;
              roundEnded = true;
            }
            DealerTurn();
        }

        private void checkWin()
        {
            checkScore();
           switch( blackJackManager.whoWon(dealer, player))
            {
                case 0:
                    bet = 0;
                    roundEnded = true;
                    break;
                    case 1:
                    break;
                    case 2:
                    payoutAmount = bet * 2;
                    bet = 0;
                    roundEnded = true;
                    break;
                    case 3:
                    payoutAmount = bet * 3;
                    bet = 0;
                    roundEnded = true;
                    break;
            }

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

       public void resetBlackjack()
        {
            player.hand = new List<CardModel>();
            player.splitHand = null;
            player.hand1Value = 0;
            player.hand2Value = 0;

            dealer.hand = new List<CardModel>();
            dealer.splitHand = null;
            dealer.hand1Value = 0;
            dealer.hand2Value = 0;
            roundEnded = true;

        }

        public void SetDeck()
        {

            int i = 1;
            int val = 1;
            for (; i < 14; i++)
            {
                CardModel card = new CardModel("Hearts", val);
                deck.Add(card);
                val++;
            }
            val = 1;
            for (; i < 27; i++)
            {
                CardModel card = new CardModel("Diamonds", val);
                deck.Add(card);
                val++;
            }
            val = 1;
            for (; i < 40; i++)
            {
                CardModel card = new CardModel("Clubs", val);
                deck.Add(card);
                val++;
            }
            val = 1;
            for (; i < 53; i++)
            {
                CardModel card = new CardModel("Spades", val);
                deck.Add(card);
                val++;
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
            for (int i = 0; i < loops; i++)
            {
                Random random = new Random();
                int cardDrawn = random.Next(deck.Count - 1);
                if(player.splitHand!= null) player.splitHand.Add(deck.ElementAt(cardDrawn));
                deck.RemoveAt(cardDrawn);
            }
        }

        public List<CardModel> getDeck()
        {
            return deck;
        }

        public void getBet(int betAmount)
        {
            bet = betAmount;
        }
        public void setPlayerName(string name)
        {
            player.name = name;
        }
    }
}