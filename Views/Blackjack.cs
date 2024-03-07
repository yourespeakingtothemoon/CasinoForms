using CasinoForms.Controllers;
using CasinoForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CasinoForms.Views
{
    public partial class Blackjack : Form
    {
        GameManager gameManager;
        ApplicationManager appManager;
        String message = "place bet to start game";

        List<PictureBox> playerHandPictureBoxes = new List<PictureBox>();
        List<PictureBox> dealerHandPictureBoxes = new List<PictureBox>();
        List<PictureBox> splitHandPictureBoxes = new List<PictureBox>();

        bool gameStart = false;
        
        public bool revealDealer = false;
        public Blackjack()
        {
            InitializeComponent();
        }
        public Blackjack(ApplicationManager app)
        {
            this.appManager = app;
            gameManager = new GameManager(app.user.toPlayer(),this);

           
            InitializeComponent();
        }

        public void revealDealerCard()
        { 
        
            revealDealer = true;
            updateBoard();
        }

        public Blackjack(GameManager gameManager, ApplicationManager appManager)
        {
            this.gameManager = gameManager;
            this.appManager = appManager;
        


            InitializeComponent();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalbet_Click(object sender, EventArgs e)
        {

        }


        private void updateBoard()
        {
            if (gameManager.roundEnded)
            {
                message = "Round Ended, bet again to start a new round";
                gameStart = false;
            }

            button1.Enabled = !gameStart;

            Message.Text = message;
            availableFunds.Text = "$" + gameManager.player.money.ToString();
            totalbet.Text = "$" + gameManager.bet.ToString();
            payout.Text = "$" + gameManager.payoutAmount.ToString();
            foreach (CardModel c in gameManager.player.hand)
            {
                int index = gameManager.player.hand.IndexOf(c);
                playerHandPictureBoxes[index].Image = getCardImage(c);
            }
            foreach (CardModel c in gameManager.dealer.hand)
            {
                int index = gameManager.dealer.hand.IndexOf(c);
                dealerHandPictureBoxes[index].Image = getCardImage(c);
                if(index == gameManager.dealer.hand.Count - 1 && !revealDealer)
                {
                    dealerHandPictureBoxes[index].Image = Properties.Resources.cardBack_red5;
                }
            }
            if (gameManager.player.splitHand != null)
            {
                foreach (CardModel c in gameManager.player.splitHand)
                {
                    int index = gameManager.player.splitHand.IndexOf(c);
                    splitHandPictureBoxes[index].Image = getCardImage(c);
                }
            }

        if(gameManager.roundEnded)
            {
                gameManager.resetBlackjack();
                revealDealer = false;
            }

        }

        private void updateHands()
        {

        }

        private void enableInsurance()
        {

        }

        private Image getCardImage(CardModel card)
        {
            if (card.suit == "Hearts")
            {
                switch (card.value)
                {
                    case 1:
                        return Properties.Resources.cardHeartsA;
                    case 2:
                        return Properties.Resources.cardHearts2;
                    case 3:
                        return Properties.Resources.cardHearts3;
                    case 4:
                        return Properties.Resources.cardHearts4;
                    case 5:
                        return Properties.Resources.cardHearts5;
                    case 6:
                        return Properties.Resources.cardHearts6;
                    case 7:
                        return Properties.Resources.cardHearts7;
                    case 8:
                        return Properties.Resources.cardHearts8;
                    case 9:
                        return Properties.Resources.cardHearts9;
                    case 10:
                        return Properties.Resources.cardHearts10;
                    case 11:
                        return Properties.Resources.cardHeartsJ;
                    case 12:
                        return Properties.Resources.cardHeartsQ;
                    case 13:
                        return Properties.Resources.cardHeartsK;

                }

            }
            else if (card.suit == "Diamonds")
            {
                switch (card.value)
                {
                    case 1:
                        return Properties.Resources.cardDiamondsA;
                    case 2:
                        return Properties.Resources.cardDiamonds2;
                    case 3:
                        return Properties.Resources.cardDiamonds3;
                    case 4:
                        return Properties.Resources.cardDiamonds4;
                    case 5:
                        return Properties.Resources.cardDiamonds5;
                    case 6:
                        return Properties.Resources.cardDiamonds6;
                    case 7:
                        return Properties.Resources.cardDiamonds7;
                    case 8:
                        return Properties.Resources.cardDiamonds8;
                    case 9:
                        return Properties.Resources.cardDiamonds9;
                    case 10:
                        return Properties.Resources.cardDiamonds10;
                    case 11:
                        return Properties.Resources.cardDiamondsJ;
                    case 12:
                        return Properties.Resources.cardDiamondsQ;
                    case 13:
                        return Properties.Resources.cardDiamondsK;


                }

            }
            else if (card.suit == "Clubs")
            {
                switch (card.value)
                {
                    case 1:
                        return Properties.Resources.cardClubsA;
                    case 2:
                        return Properties.Resources.cardClubs2;
                    case 3:
                        return Properties.Resources.cardClubs3;
                    case 4:
                        return Properties.Resources.cardClubs4;
                    case 5:
                        return Properties.Resources.cardClubs5;
                    case 6:
                        return Properties.Resources.cardClubs6;
                    case 7:
                        return Properties.Resources.cardClubs7;
                    case 8:
                        return Properties.Resources.cardClubs8;
                    case 9:
                        return Properties.Resources.cardClubs9;
                    case 10:
                        return Properties.Resources.cardClubs10;
                    case 11:
                        return Properties.Resources.cardClubsJ;
                    case 12:
                        return Properties.Resources.cardClubsQ;
                    case 13:
                        return Properties.Resources.cardClubsK;
                }

            }
            else if (card.suit == "Spades")
            {
                switch (card.value)
                {
                    case 1:
                        return Properties.Resources.cardSpadesA;
                    case 2:
                        return Properties.Resources.cardSpades2;
                    case 3:
                        return Properties.Resources.cardSpades3;
                    case 4:
                        return Properties.Resources.cardSpades4;
                    case 5:
                        return Properties.Resources.cardSpades5;
                    case 6:
                        return Properties.Resources.cardSpades6;
                    case 7:
                        return Properties.Resources.cardSpades7;
                    case 8:
                        return Properties.Resources.cardSpades8;
                    case 9:
                        return Properties.Resources.cardSpades9;
                    case 10:
                        return Properties.Resources.cardSpades10;
                    case 11:
                        return Properties.Resources.cardSpadesJ;
                    case 12:
                        return Properties.Resources.cardSpadesQ;
                    case 13:
                        return Properties.Resources.cardSpadesK;

                }

            }
           
                return Properties.Resources.Layer_2;
           
        }

        private void HitButton_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {


                gameManager.playerTurn("draw");
                updateBoard();
            }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void StandButton_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {

                gameManager.playerTurn("Stand");
                updateBoard();
            }
        }

        private void chipfive_Click(object sender, EventArgs e)
        {

            if (!gameStart)
            {
                startGame();
                gameManager.bet += 5;
            }


            updateBoard();
        }

        private void chiptwenty_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                startGame();
                gameManager.bet += 20;
            }

            updateBoard();

        }

        private void chipfifty_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                startGame();
                gameManager.bet += 50;
            }

            updateBoard();

        }

        private void chiphundred_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                startGame();
                gameManager.bet += 100;
            }

            updateBoard();

        }

        private void chipfiveh_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                startGame();
                gameManager.bet += 500;
            }

            updateBoard();

        }

        private void chipthousand_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                startGame();
                gameManager.bet += 1000;
            }

            updateBoard();

        }

        private void chipfivek_Click(object sender, EventArgs e)
        {
            if (!gameStart)
            {
                startGame();
            }
            gameManager.bet += 5000;
            updateBoard();

        }


        private void startGame()
        {
            playerHandPictureBoxes.Add(card1);
            playerHandPictureBoxes.Add(card2);
            playerHandPictureBoxes.Add(card3);
            playerHandPictureBoxes.Add(card4);
            playerHandPictureBoxes.Add(card5);
            playerHandPictureBoxes.Add(card6);
            playerHandPictureBoxes.Add(card7);

            dealerHandPictureBoxes.Add(dealercard1);
            dealerHandPictureBoxes.Add(dealercard2);
            dealerHandPictureBoxes.Add(dealercard3);
            dealerHandPictureBoxes.Add(dealercard4);
            dealerHandPictureBoxes.Add(dealercard5);
            dealerHandPictureBoxes.Add(dealercard6);
            dealerHandPictureBoxes.Add(dealercard7);

            splitHandPictureBoxes.Add(split1);
            splitHandPictureBoxes.Add(split2);
            splitHandPictureBoxes.Add(split3);
            splitHandPictureBoxes.Add(split4);
            splitHandPictureBoxes.Add(split5);
            splitHandPictureBoxes.Add(split6);
            splitHandPictureBoxes.Add(split7);
            splitHandPictureBoxes.Add(split8);
            foreach (PictureBox p in playerHandPictureBoxes)
            {
                p.Image = Properties.Resources.Layer_2;
            }
            foreach (PictureBox p in dealerHandPictureBoxes)
            {
                p.Image = Properties.Resources.Layer_2;
            }
            foreach (PictureBox p in splitHandPictureBoxes)
            {
                p.Image = Properties.Resources.Layer_2;
            }
            gameManager.StartBlackJack();
            message = "";
            gameStart = true;
            gameManager.roundEnded = false;
            updateBoard();
        }

        private void Split_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {

                gameManager.playerTurn("split");
                updateBoard();
            }
        }

        private void DDButton_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {

                gameManager.playerTurn("DoubleDown");
                updateBoard();
            }
        }

        private void Surrender_Click(object sender, EventArgs e)
        {
            if (gameStart)
            {

                gameManager.playerTurn("Surrender");
                updateBoard();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            appManager.Payout(gameManager.player);
            
            
            this.Close();


        }
    }
}
